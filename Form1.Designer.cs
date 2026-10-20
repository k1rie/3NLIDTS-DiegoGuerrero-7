namespace _3NLIDTS_DiegoGuerrero_7;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnEncender = new Button();
        btnApagar = new Button();
        SuspendLayout();
        //
        // btnEncender
        //
        btnEncender.Location = new Point(60, 30);
        btnEncender.Name = "btnEncender";
        btnEncender.Size = new Size(160, 45);
        btnEncender.TabIndex = 0;
        btnEncender.Text = "Encender LED";
        btnEncender.UseVisualStyleBackColor = true;
        //
        // btnApagar
        //
        btnApagar.Location = new Point(60, 95);
        btnApagar.Name = "btnApagar";
        btnApagar.Size = new Size(160, 45);
        btnApagar.TabIndex = 1;
        btnApagar.Text = "Apagar LED";
        btnApagar.UseVisualStyleBackColor = true;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(280, 170);
        Controls.Add(btnApagar);
        Controls.Add(btnEncender);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Actividad 07 - Encendido de LED";
        ResumeLayout(false);
    }

    #endregion

    private Button btnEncender;
    private Button btnApagar;
}
