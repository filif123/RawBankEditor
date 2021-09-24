
namespace RawBankEditor.Controls
{
    partial class MinButton
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MinMaxButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MinButton";
            this.Size = new System.Drawing.Size(16, 16);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MinMaxButton_Paint);
            this.MouseEnter += new System.EventHandler(this.MinMaxButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MinMaxButton_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
