namespace TelepresenceCommonPacketTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeneratedPathText = new System.Windows.Forms.TextBox();
            this.GeneratedButton = new System.Windows.Forms.Button();
            this.Camel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pascal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.excludeSizeCode = new System.Windows.Forms.RadioButton();
            this.includeSizeCode = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SavePathText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inCludeRegion = new System.Windows.Forms.RadioButton();
            this.exCLudeRegion = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.PacketDataName = new System.Windows.Forms.TextBox();
            this.LandPacketFront = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MySpacePacketFront = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressText = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ALLALL = new System.Windows.Forms.RadioButton();
            this.ServerToClient = new System.Windows.Forms.RadioButton();
            this.ClientToServer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telepresence Common Packet Generator";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generate 폴더 경로";
            // 
            // GeneratedPathText
            // 
            this.GeneratedPathText.Location = new System.Drawing.Point(152, 61);
            this.GeneratedPathText.Name = "GeneratedPathText";
            this.GeneratedPathText.Size = new System.Drawing.Size(406, 25);
            this.GeneratedPathText.TabIndex = 2;
            // 
            // GeneratedButton
            // 
            this.GeneratedButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GeneratedButton.Location = new System.Drawing.Point(564, 61);
            this.GeneratedButton.Name = "GeneratedButton";
            this.GeneratedButton.Size = new System.Drawing.Size(78, 26);
            this.GeneratedButton.TabIndex = 3;
            this.GeneratedButton.Text = "찾기...";
            this.GeneratedButton.UseVisualStyleBackColor = true;
            this.GeneratedButton.Click += new System.EventHandler(this.GeneratedButton_Click);
            // 
            // Camel
            // 
            this.Camel.Checked = true;
            this.Camel.Location = new System.Drawing.Point(6, 26);
            this.Camel.Name = "Camel";
            this.Camel.Size = new System.Drawing.Size(151, 24);
            this.Camel.TabIndex = 4;
            this.Camel.TabStop = true;
            this.Camel.Text = "카멜 표기법";
            this.Camel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pascal);
            this.groupBox1.Controls.Add(this.Camel);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "추상 클래스 명명 규칙";
            // 
            // Pascal
            // 
            this.Pascal.Location = new System.Drawing.Point(6, 56);
            this.Pascal.Name = "Pascal";
            this.Pascal.Size = new System.Drawing.Size(144, 24);
            this.Pascal.TabIndex = 5;
            this.Pascal.Text = "파스칼 표기법";
            this.Pascal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.excludeSizeCode);
            this.groupBox2.Controls.Add(this.includeSizeCode);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 88);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "패킷 Size,Code 포함 여부";
            // 
            // excludeSizeCode
            // 
            this.excludeSizeCode.Location = new System.Drawing.Point(6, 56);
            this.excludeSizeCode.Name = "excludeSizeCode";
            this.excludeSizeCode.Size = new System.Drawing.Size(151, 24);
            this.excludeSizeCode.TabIndex = 7;
            this.excludeSizeCode.Text = "미포함";
            this.excludeSizeCode.UseVisualStyleBackColor = true;
            // 
            // includeSizeCode
            // 
            this.includeSizeCode.Checked = true;
            this.includeSizeCode.Location = new System.Drawing.Point(6, 26);
            this.includeSizeCode.Name = "includeSizeCode";
            this.includeSizeCode.Size = new System.Drawing.Size(151, 24);
            this.includeSizeCode.TabIndex = 6;
            this.includeSizeCode.TabStop = true;
            this.includeSizeCode.Text = "포함";
            this.includeSizeCode.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Info;
            this.StartButton.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartButton.Location = new System.Drawing.Point(446, 341);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(196, 100);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "생성하기";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveButton.Location = new System.Drawing.Point(564, 94);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(78, 26);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "찾기...";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SavePathText
            // 
            this.SavePathText.Location = new System.Drawing.Point(152, 94);
            this.SavePathText.Name = "SavePathText";
            this.SavePathText.Size = new System.Drawing.Size(406, 25);
            this.SavePathText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "저장할 폴더 경로";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(648, 61);
            this.textBox3.MaxLength = 2100000000;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 340);
            this.textBox3.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(648, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 34);
            this.button4.TabIndex = 13;
            this.button4.Text = "복사하기";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inCludeRegion);
            this.groupBox3.Controls.Add(this.exCLudeRegion);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(213, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 88);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "#Region 포함 여부";
            // 
            // inCludeRegion
            // 
            this.inCludeRegion.Checked = true;
            this.inCludeRegion.Location = new System.Drawing.Point(6, 26);
            this.inCludeRegion.Name = "inCludeRegion";
            this.inCludeRegion.Size = new System.Drawing.Size(144, 24);
            this.inCludeRegion.TabIndex = 6;
            this.inCludeRegion.TabStop = true;
            this.inCludeRegion.Text = "포함";
            this.inCludeRegion.UseVisualStyleBackColor = true;
            // 
            // exCLudeRegion
            // 
            this.exCLudeRegion.Location = new System.Drawing.Point(6, 56);
            this.exCLudeRegion.Name = "exCLudeRegion";
            this.exCLudeRegion.Size = new System.Drawing.Size(144, 24);
            this.exCLudeRegion.TabIndex = 5;
            this.exCLudeRegion.Text = "미포함";
            this.exCLudeRegion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "패킷 데이터 이름 (Default : data)";
            // 
            // PacketDataName
            // 
            this.PacketDataName.Location = new System.Drawing.Point(245, 133);
            this.PacketDataName.Name = "PacketDataName";
            this.PacketDataName.Size = new System.Drawing.Size(125, 25);
            this.PacketDataName.TabIndex = 15;
            // 
            // LandPacketFront
            // 
            this.LandPacketFront.Location = new System.Drawing.Point(162, 164);
            this.LandPacketFront.Name = "LandPacketFront";
            this.LandPacketFront.Size = new System.Drawing.Size(125, 25);
            this.LandPacketFront.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Land 대상 패킷 이름";
            // 
            // MySpacePacketFront
            // 
            this.MySpacePacketFront.Location = new System.Drawing.Point(180, 195);
            this.MySpacePacketFront.Name = "MySpacePacketFront";
            this.MySpacePacketFront.Size = new System.Drawing.Size(125, 25);
            this.MySpacePacketFront.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "MySpace대상 패킷 이름";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 447);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(858, 23);
            this.progressBar.TabIndex = 20;
            // 
            // progressText
            // 
            this.progressText.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.progressText.Location = new System.Drawing.Point(12, 477);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(244, 25);
            this.progressText.TabIndex = 21;
            this.progressText.Text = "Progress....";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ALLALL);
            this.groupBox4.Controls.Add(this.ServerToClient);
            this.groupBox4.Controls.Add(this.ClientToServer);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(219, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 109);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "추출 타입";
            // 
            // ALLALL
            // 
            this.ALLALL.Checked = true;
            this.ALLALL.Location = new System.Drawing.Point(6, 85);
            this.ALLALL.Name = "ALLALL";
            this.ALLALL.Size = new System.Drawing.Size(206, 24);
            this.ALLALL.TabIndex = 6;
            this.ALLALL.TabStop = true;
            this.ALLALL.Text = "All";
            this.ALLALL.UseVisualStyleBackColor = true;
            // 
            // ServerToClient
            // 
            this.ServerToClient.Location = new System.Drawing.Point(6, 56);
            this.ServerToClient.Name = "ServerToClient";
            this.ServerToClient.Size = new System.Drawing.Size(206, 24);
            this.ServerToClient.TabIndex = 5;
            this.ServerToClient.Text = "Server To Client Packets";
            this.ServerToClient.UseVisualStyleBackColor = true;
            // 
            // ClientToServer
            // 
            this.ClientToServer.Location = new System.Drawing.Point(6, 26);
            this.ClientToServer.Name = "ClientToServer";
            this.ClientToServer.Size = new System.Drawing.Size(206, 24);
            this.ClientToServer.TabIndex = 4;
            this.ClientToServer.Text = "Client To Server Packets";
            this.ClientToServer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.MySpacePacketFront);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LandPacketFront);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PacketDataName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SavePathText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GeneratedButton);
            this.Controls.Add(this.GeneratedPathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telepresence Common Packet Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton ALLALL;

        private System.Windows.Forms.RadioButton inCludeRegion;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton ServerToClient;
        private System.Windows.Forms.RadioButton ClientToServer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton includeSizeCode;
        private System.Windows.Forms.RadioButton excludeSizeCode;

        private System.Windows.Forms.Label progressText;

        private System.Windows.Forms.ProgressBar progressBar;

        private System.Windows.Forms.TextBox LandPacketFront;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MySpacePacketFront;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PacketDataName;

        private System.Windows.Forms.RadioButton exCLudeRegion;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SavePathText;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StartButton;

        private System.Windows.Forms.RadioButton Pascal;

        private System.Windows.Forms.RadioButton Camel;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GeneratedPathText;
        private System.Windows.Forms.Button GeneratedButton;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}