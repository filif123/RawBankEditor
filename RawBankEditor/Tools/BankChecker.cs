using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using RawBankEditor.Entities;

namespace RawBankEditor.Tools
{
    internal class BankChecker
    {
        public static List<FyzSound> CheckBankWAVs(FyzLanguage lang, BackgroundWorker worker = null, bool checkDuration = false)
        {
            var sounds = new List<FyzSound>();

            worker?.ReportProgress(0, lang.Groups.Count);

            var i = 0;
            foreach (var grp in lang.Groups)
            {
                foreach (var sound in grp.Sounds)
                {
                    var path = GlobData.AbsPathToBank + lang.RelativePath + grp.RelativePath + sound.AdditionalRelativePath;
                    if (!File.Exists(path))
                        //Sound has no WAV
                        sounds.Add(sound);
                    else if (checkDuration) sound.Duration = SoundUtils.GetSoundDuration(path);
                }

                worker?.ReportProgress(++i);
            }

            return sounds;
        }
    }
}