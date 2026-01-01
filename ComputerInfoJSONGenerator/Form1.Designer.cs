namespace ComputerInfoJSONGenerator;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(193, 380);
        button1.Name = "Generate JSON";
        button1.Size = new System.Drawing.Size(166, 100);
        button1.TabIndex = 0;
        button1.Text = "Generate JSON";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(468, 380);
        button2.Name = "Exit Application";
        button2.Size = new System.Drawing.Size(166, 100);
        button2.TabIndex = 1;
        button2.Text = "Exit";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(193, 102);
        label1.Name = "Application information";
        label1.Size = new System.Drawing.Size(441, 76);
        label1.TabIndex = 2;
        label1.Text = "This application will generate a 'specs.json' file in the directory where the application executable is stored.";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(842, 569);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Computer Specs JSON Generator";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}