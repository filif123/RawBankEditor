using RawBankEditor.Entities;

namespace RawBankEditor.Forms;

public partial class FMain
{
    public enum PropertyType
    {
        Name,
        Key,
        FileName,
        RelativePath,
        Text
    }

    /// <summary>
    ///     Vseobecna akcia
    /// </summary>
    public abstract class Action
    {
        protected Action(FMain form)
        {
            Form = form ?? throw new ArgumentNullException(nameof(form));
        }

        protected FMain Form { get; }
    }

    /// <summary>
    ///     Akcia pri pohybe - neobsahuje zmeny, okrem zmeny pozicie
    /// </summary>
    public abstract class MoveAction : Action
    {
        /// <summary>Initializes a new instance of the <see cref="MoveAction" /> class.</summary>
        protected MoveAction(FMain form) : base(form)
        {
        }

        public abstract void Execute();
    }

    /// <summary>
    ///     Akcia pri akejkolvek zmene - pridanie, uprava, zmazanie
    /// </summary>
    public abstract class ChangeAction : Action
    {
        /// <summary>Initializes a new instance of the <see cref="ChangeAction" /> class.</summary>
        protected ChangeAction(FMain form) : base(form)
        {
        }

        public abstract void Undo();

        public abstract void Redo();
    }

    /// <summary>
    ///     Akcia pri zmene oznacenych buniek v tabulke so zvukmi
    /// </summary>
    public class SelectedCellSoundMoveAction : MoveAction
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public SelectedCellSoundMoveAction(FMain form, object[] selected, FyzLanguage language, FyzGroup group) : base(form)
        {
            SelectedItems = selected;
            Language = language;
            Group = group;
        }

        public object[] SelectedItems { get; }

        public FyzLanguage Language { get; }

        public FyzGroup Group { get; }

        public override void Execute()
        {
            Form.programSelection = true;
            Form.tscboxLanguages.SelectedItem = Language;
            Form.lboxGroups.SelectedItem = Group;
            Form.dgvSounds.ClearSelection();

            foreach (DataGridViewRow r in Form.dgvSounds.Rows)
            foreach (var s in SelectedItems)
                if (r.DataBoundItem == s)
                    r.Selected = true;

            Form.programSelection = false;
        }
    }

    /// <summary>
    ///     Akcia pri vseobecnej praci so zvukmi
    /// </summary>
    public abstract class SoundAction : ChangeAction
    {
        protected SoundAction(FMain form, FyzLanguage language, FyzGroup group) : base(form)
        {
            Language = language;
            Group = group;
        }

        protected FyzLanguage Language { get; }

        protected FyzGroup Group { get; }
    }

    /// <summary>
    ///     Akcia pri uprave vlastnosti zvuku
    /// </summary>
    public class EditSoundAction : SoundAction
    {
        public EditSoundAction(FMain form, FyzLanguage language, FyzGroup group) : base(form, language, group)
        {
        }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public int Row { get; set; }

        public PropertyType Type { get; set; }

        public override void Undo()
        {
            Form.tscboxLanguages.SelectedItem = Language;
            Form.lboxGroups.SelectedItem = Group;

            var sound = Group.Sounds[Row];
            switch (Type)
            {
                case PropertyType.Name:
                    sound.Name = OldValue;
                    break;
                case PropertyType.Key:
                    sound.Key = OldValue;
                    break;
                case PropertyType.FileName:
                    sound.FileName = OldValue;
                    break;
                case PropertyType.RelativePath:
                    sound.AdditionalRelativePath = OldValue;
                    break;
                case PropertyType.Text:
                    sound.Text = OldValue;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Group.Sounds.ResetBindings();
        }

        public override void Redo()
        {
            Form.tscboxLanguages.SelectedItem = Language;
            Form.lboxGroups.SelectedItem = Group;

            var sound = Group.Sounds[Row];
            switch (Type)
            {
                case PropertyType.Name:
                    sound.Name = NewValue;
                    break;
                case PropertyType.Key:
                    sound.Key = NewValue;
                    break;
                case PropertyType.FileName:
                    sound.FileName = NewValue;
                    break;
                case PropertyType.RelativePath:
                    sound.AdditionalRelativePath = NewValue;
                    break;
                case PropertyType.Text:
                    sound.Text = NewValue;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Group.Sounds.ResetBindings();
        }
    }

    public readonly struct FyzSoundPos
    {
        public FyzSound Sound { get; }
        public int Row { get; }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public FyzSoundPos(FyzSound sound, int row)
        {
            Sound = sound;
            Row = row;
        }
    }

    /// <summary>
    ///     Akcia pri odstraneni viacerych (alebo 1) zvukov
    /// </summary>
    public class RemovedSoundsAction : SoundAction
    {
        /// <summary>Initializes a new instance of the <see cref="ChangeAction" /> class.</summary>
        public RemovedSoundsAction(FMain form, FyzLanguage language, FyzGroup group) : base(form, language, group)
        {
        }

        public IEnumerable<FyzSoundPos> Sounds { get; set; }

        public override void Undo()
        {
            Form.tscboxLanguages.SelectedItem = Language;
            Form.lboxGroups.SelectedItem = Group;

            foreach (var sound in Sounds)
            {
                Group.Sounds.Insert(sound.Row, sound.Sound);
                Form.dgvSounds.Rows[sound.Row].Selected = true;
            }
        }

        public override void Redo()
        {
            Form.tscboxLanguages.SelectedItem = Language;
            Form.lboxGroups.SelectedItem = Group;

            foreach (var sound in Sounds) Group.Sounds.RemoveAt(sound.Row);
        }
    }

    public class AddSoundAction : SoundAction
    {
        public AddSoundAction(FMain form, FyzLanguage language, FyzGroup group, int row) : base(form, language, group)
        {
            Row = row;
        }

        public int Row { get; }

        public override void Undo()
        {
            Form.tscboxLanguages.SelectedItem = Language;
            Form.lboxGroups.SelectedItem = Group;

            Form.dgvSounds.Rows.RemoveAt(Row);
        }

        public override void Redo()
        {
            Form.tscboxLanguages.SelectedItem = Language;
            Form.lboxGroups.SelectedItem = Group;
            //Form.dgvSounds.ClearSelection();

            Group.Sounds.Insert(Row, new FyzSound());
            //Form.dgvSounds.Rows[Form.dgvSounds.Rows.Count - 1].Selected = true;
        }
    }
}