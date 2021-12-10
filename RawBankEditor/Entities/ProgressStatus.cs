namespace RawBankEditor.Entities;

internal class ProgressStatus
{
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public ProgressStatus(string progressPartName, int totalProgress)
    {
        ProgressPartName = progressPartName;
        TotalProgress = totalProgress;
    }

    public string ProgressPartName { get; set; }

    public int TotalProgress { get; set; }
}