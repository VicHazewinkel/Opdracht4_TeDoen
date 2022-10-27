namespace Oefening
{
    partial class TakenBeheer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private FouteRij<TeDoen> rijen = new FouteRij<TeDoen>(); 


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
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_NextTask = new System.Windows.Forms.Button();
            this.textBox_InformationInput = new System.Windows.Forms.TextBox();
            this.textBox_TitleInput = new System.Windows.Forms.TextBox();
            this.label_TitleInput = new System.Windows.Forms.Label();
            this.label_InformationInput = new System.Windows.Forms.Label();
            this.dateTimePicker_Input = new System.Windows.Forms.DateTimePicker();
            this.checkBox_Time = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TasksOutput = new System.Windows.Forms.Label();
            this.label_huidigeTast = new System.Windows.Forms.Label();
            this.label_curentTaskOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(543, 240);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(462, 240);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(75, 23);
            this.button_Last.TabIndex = 2;
            this.button_Last.Text = "Last";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_NextTask
            // 
            this.button_NextTask.Location = new System.Drawing.Point(381, 240);
            this.button_NextTask.Name = "button_NextTask";
            this.button_NextTask.Size = new System.Drawing.Size(75, 23);
            this.button_NextTask.TabIndex = 3;
            this.button_NextTask.Text = "Next Task";
            this.button_NextTask.UseVisualStyleBackColor = true;
            this.button_NextTask.Click += new System.EventHandler(this.button_NextTask_Click);
            // 
            // textBox_InformationInput
            // 
            this.textBox_InformationInput.Location = new System.Drawing.Point(88, 107);
            this.textBox_InformationInput.Name = "textBox_InformationInput";
            this.textBox_InformationInput.Size = new System.Drawing.Size(258, 23);
            this.textBox_InformationInput.TabIndex = 4;
            // 
            // textBox_TitleInput
            // 
            this.textBox_TitleInput.Location = new System.Drawing.Point(88, 78);
            this.textBox_TitleInput.Name = "textBox_TitleInput";
            this.textBox_TitleInput.Size = new System.Drawing.Size(258, 23);
            this.textBox_TitleInput.TabIndex = 5;
            this.textBox_TitleInput.TextChanged += new System.EventHandler(this.textBox_TitleInput_TextChanged);
            // 
            // label_TitleInput
            // 
            this.label_TitleInput.AutoSize = true;
            this.label_TitleInput.Location = new System.Drawing.Point(53, 78);
            this.label_TitleInput.Name = "label_TitleInput";
            this.label_TitleInput.Size = new System.Drawing.Size(29, 15);
            this.label_TitleInput.TabIndex = 6;
            this.label_TitleInput.Text = "Title";
            // 
            // label_InformationInput
            // 
            this.label_InformationInput.AutoSize = true;
            this.label_InformationInput.Location = new System.Drawing.Point(12, 110);
            this.label_InformationInput.Name = "label_InformationInput";
            this.label_InformationInput.Size = new System.Drawing.Size(70, 15);
            this.label_InformationInput.TabIndex = 7;
            this.label_InformationInput.Text = "Information";
            this.label_InformationInput.Click += new System.EventHandler(this.label_InformationInput_Click);
            // 
            // dateTimePicker_Input
            // 
            this.dateTimePicker_Input.Location = new System.Drawing.Point(88, 238);
            this.dateTimePicker_Input.Name = "dateTimePicker_Input";
            this.dateTimePicker_Input.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_Input.TabIndex = 8;
            // 
            // checkBox_Time
            // 
            this.checkBox_Time.AutoSize = true;
            this.checkBox_Time.Location = new System.Drawing.Point(294, 238);
            this.checkBox_Time.Name = "checkBox_Time";
            this.checkBox_Time.Size = new System.Drawing.Size(52, 19);
            this.checkBox_Time.TabIndex = 10;
            this.checkBox_Time.Text = "Time";
            this.checkBox_Time.UseVisualStyleBackColor = true;
            this.checkBox_Time.CheckedChanged += new System.EventHandler(this.checkBox_Time_CheckedChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(294, 263);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(52, 23);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tasks";
            // 
            // label_TasksOutput
            // 
            this.label_TasksOutput.AutoSize = true;
            this.label_TasksOutput.Location = new System.Drawing.Point(381, 78);
            this.label_TasksOutput.Name = "label_TasksOutput";
            this.label_TasksOutput.Size = new System.Drawing.Size(34, 15);
            this.label_TasksOutput.TabIndex = 13;
            this.label_TasksOutput.Text = ". . . . .";
            // 
            // label_huidigeTast
            // 
            this.label_huidigeTast.AutoSize = true;
            this.label_huidigeTast.Location = new System.Drawing.Point(381, 155);
            this.label_huidigeTast.Name = "label_huidigeTast";
            this.label_huidigeTast.Size = new System.Drawing.Size(68, 15);
            this.label_huidigeTast.TabIndex = 14;
            this.label_huidigeTast.Text = "Curent Task";
            // 
            // label_curentTaskOutput
            // 
            this.label_curentTaskOutput.AutoSize = true;
            this.label_curentTaskOutput.Location = new System.Drawing.Point(381, 181);
            this.label_curentTaskOutput.Name = "label_curentTaskOutput";
            this.label_curentTaskOutput.Size = new System.Drawing.Size(34, 15);
            this.label_curentTaskOutput.TabIndex = 15;
            this.label_curentTaskOutput.Text = ". . . . .";
            // 
            // TakenBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_curentTaskOutput);
            this.Controls.Add(this.label_huidigeTast);
            this.Controls.Add(this.label_TasksOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.checkBox_Time);
            this.Controls.Add(this.dateTimePicker_Input);
            this.Controls.Add(this.label_InformationInput);
            this.Controls.Add(this.label_TitleInput);
            this.Controls.Add(this.textBox_TitleInput);
            this.Controls.Add(this.textBox_InformationInput);
            this.Controls.Add(this.button_NextTask);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.button_Delete);
            this.Name = "TakenBeheer";
            this.Text = "Taken Beheer";
            this.Load += new System.EventHandler(this.TakenBeheer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_Delete;
        private Button button_Last;
        private Button button_NextTask;
        private TextBox textBox_InformationInput;
        private TextBox textBox_TitleInput;
        private Label label_TitleInput;
        private Label label_InformationInput;
        private DateTimePicker dateTimePicker_Input;
        private CheckBox checkBox_Time;
        private Button button_Save;
        private Label label1;
        private Label label_TasksOutput;
        private Label label_huidigeTast;
        private Label label_curentTaskOutput;
    }
}