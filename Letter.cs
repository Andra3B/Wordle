using System;
using System.Windows.Forms;

public class Letter : TextBox
{
    public Letter() : base()
    {
        this.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Location = new System.Drawing.Point(350, 69);
        this.MaxLength = 1;
        this.Name = "txtLetter";
        this.Size = new System.Drawing.Size(100, 20);
        this.TabIndex = 0;
        this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
    }
}