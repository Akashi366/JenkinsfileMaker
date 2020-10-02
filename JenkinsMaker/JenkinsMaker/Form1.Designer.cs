namespace JenkinsMaker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.paramsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.solutionPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TargetDirectory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paramsBox = new System.Windows.Forms.GroupBox();
            this.serverTab = new System.Windows.Forms.TabControl();
            this.ServersTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.connectionsTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hostFile = new System.Windows.Forms.TextBox();
            this.HostFolder = new System.Windows.Forms.TextBox();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.webPanel = new System.Windows.Forms.Panel();
            this.ProdServerSelected = new System.Windows.Forms.Label();
            this.ServerBox = new System.Windows.Forms.ComboBox();
            this.webName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.paramsBox.SuspendLayout();
            this.serverTab.SuspendLayout();
            this.ServersTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.servicePanel.SuspendLayout();
            this.webPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulaire de création de Jenkinsfile";
            // 
            // paramsButton
            // 
            this.paramsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paramsButton.Location = new System.Drawing.Point(620, 21);
            this.paramsButton.Name = "paramsButton";
            this.paramsButton.Size = new System.Drawing.Size(150, 40);
            this.paramsButton.TabIndex = 1;
            this.paramsButton.Text = "Paramètres";
            this.paramsButton.UseVisualStyleBackColor = true;
            this.paramsButton.Click += new System.EventHandler(this.paramsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom du projet : ";
            // 
            // projectName
            // 
            this.projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.Location = new System.Drawing.Point(161, 36);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(211, 30);
            this.projectName.TabIndex = 3;
            this.projectName.TextChanged += new System.EventHandler(this.projectName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chemin vers le fichier solution :";
            // 
            // solutionPath
            // 
            this.solutionPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionPath.Location = new System.Drawing.Point(0, 114);
            this.solutionPath.Name = "solutionPath";
            this.solutionPath.Size = new System.Drawing.Size(372, 30);
            this.solutionPath.TabIndex = 5;
            this.solutionPath.TextChanged += new System.EventHandler(this.solutionPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Types de projets contenus dans la solution : ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(36, 272);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Application Web";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(36, 307);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(297, 29);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Bibliothèque de services WCF";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TargetDirectory);
            this.groupBox1.Controls.Add(this.paramsButton);
            this.groupBox1.Controls.Add(this.projectName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.solutionPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 344);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres de la solution";
            // 
            // TargetDirectory
            // 
            this.TargetDirectory.AutoSize = true;
            this.TargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetDirectory.Location = new System.Drawing.Point(7, 193);
            this.TargetDirectory.Name = "TargetDirectory";
            this.TargetDirectory.Size = new System.Drawing.Size(70, 24);
            this.TargetDirectory.TabIndex = 10;
            this.TargetDirectory.Text = "label14";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Répertoire cible :";
            // 
            // paramsBox
            // 
            this.paramsBox.Controls.Add(this.serverTab);
            this.paramsBox.Controls.Add(this.button1);
            this.paramsBox.Location = new System.Drawing.Point(12, 6);
            this.paramsBox.Name = "paramsBox";
            this.paramsBox.Size = new System.Drawing.Size(776, 388);
            this.paramsBox.TabIndex = 14;
            this.paramsBox.TabStop = false;
            this.paramsBox.Text = "Paramètres";
            // 
            // serverTab
            // 
            this.serverTab.Controls.Add(this.ServersTab);
            this.serverTab.Controls.Add(this.connectionsTab);
            this.serverTab.Controls.Add(this.tabPage2);
            this.serverTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTab.Location = new System.Drawing.Point(6, 60);
            this.serverTab.Name = "serverTab";
            this.serverTab.SelectedIndex = 0;
            this.serverTab.Size = new System.Drawing.Size(764, 322);
            this.serverTab.TabIndex = 1;
            // 
            // ServersTab
            // 
            this.ServersTab.Controls.Add(this.listView1);
            this.ServersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersTab.Location = new System.Drawing.Point(4, 34);
            this.ServersTab.Name = "ServersTab";
            this.ServersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServersTab.Size = new System.Drawing.Size(756, 284);
            this.ServersTab.TabIndex = 0;
            this.ServersTab.Text = "Serveurs";
            this.ServersTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(698, 244);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // connectionsTab
            // 
            this.connectionsTab.Location = new System.Drawing.Point(4, 34);
            this.connectionsTab.Name = "connectionsTab";
            this.connectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionsTab.Size = new System.Drawing.Size(756, 284);
            this.connectionsTab.TabIndex = 1;
            this.connectionsTab.Text = "Connexions";
            this.connectionsTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 284);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Autres options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(675, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(652, 400);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(136, 38);
            this.CreateButton.TabIndex = 15;
            this.CreateButton.Text = "Créer";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(510, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Suivant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(368, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Précédent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.servicePanel);
            this.groupBox2.Controls.Add(this.webPanel);
            this.groupBox2.Location = new System.Drawing.Point(12, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 344);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paramètres des projets";
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.label14);
            this.servicePanel.Controls.Add(this.comboBox1);
            this.servicePanel.Controls.Add(this.hostFile);
            this.servicePanel.Controls.Add(this.HostFolder);
            this.servicePanel.Controls.Add(this.serviceName);
            this.servicePanel.Controls.Add(this.label13);
            this.servicePanel.Controls.Add(this.label12);
            this.servicePanel.Controls.Add(this.label11);
            this.servicePanel.Controls.Add(this.label10);
            this.servicePanel.Controls.Add(this.label7);
            this.servicePanel.Location = new System.Drawing.Point(379, 36);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(381, 278);
            this.servicePanel.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "label14";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 33);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hostFile
            // 
            this.hostFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostFile.Location = new System.Drawing.Point(119, 136);
            this.hostFile.Name = "hostFile";
            this.hostFile.Size = new System.Drawing.Size(241, 30);
            this.hostFile.TabIndex = 7;
            this.hostFile.TextChanged += new System.EventHandler(this.hostFile_TextChanged);
            // 
            // HostFolder
            // 
            this.HostFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostFolder.Location = new System.Drawing.Point(153, 97);
            this.HostFolder.Name = "HostFolder";
            this.HostFolder.Size = new System.Drawing.Size(207, 30);
            this.HostFolder.TabIndex = 6;
            this.HostFolder.TextChanged += new System.EventHandler(this.HostFolder_TextChanged);
            // 
            // serviceName
            // 
            this.serviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceName.Location = new System.Drawing.Point(83, 52);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(195, 30);
            this.serviceName.TabIndex = 5;
            this.serviceName.TextChanged += new System.EventHandler(this.serviceName_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Serveur de production : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Host.exe : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Dossier Host : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nom : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bibliothèque de services WCF";
            // 
            // webPanel
            // 
            this.webPanel.Controls.Add(this.ProdServerSelected);
            this.webPanel.Controls.Add(this.ServerBox);
            this.webPanel.Controls.Add(this.webName);
            this.webPanel.Controls.Add(this.label9);
            this.webPanel.Controls.Add(this.label8);
            this.webPanel.Controls.Add(this.label6);
            this.webPanel.Location = new System.Drawing.Point(17, 36);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(349, 278);
            this.webPanel.TabIndex = 0;
            // 
            // ProdServerSelected
            // 
            this.ProdServerSelected.AutoSize = true;
            this.ProdServerSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdServerSelected.Location = new System.Drawing.Point(19, 181);
            this.ProdServerSelected.Name = "ProdServerSelected";
            this.ProdServerSelected.Size = new System.Drawing.Size(75, 25);
            this.ProdServerSelected.TabIndex = 5;
            this.ProdServerSelected.Text = "label14";
            // 
            // ServerBox
            // 
            this.ServerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerBox.FormattingEnabled = true;
            this.ServerBox.Location = new System.Drawing.Point(24, 143);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(292, 33);
            this.ServerBox.TabIndex = 4;
            this.ServerBox.SelectedIndexChanged += new System.EventHandler(this.ServerBox_SelectedIndexChanged);
            // 
            // webName
            // 
            this.webName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webName.Location = new System.Drawing.Point(79, 52);
            this.webName.Name = "webName";
            this.webName.Size = new System.Drawing.Size(237, 30);
            this.webName.TabIndex = 3;
            this.webName.TextChanged += new System.EventHandler(this.webName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Serveur de production : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nom : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Application Web";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paramsBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Jenkinsfile Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.paramsBox.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
            this.ServersTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.servicePanel.ResumeLayout(false);
            this.servicePanel.PerformLayout();
            this.webPanel.ResumeLayout(false);
            this.webPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paramsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox solutionPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox paramsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl serverTab;
        private System.Windows.Forms.TabPage ServersTab;
        private System.Windows.Forms.TabPage connectionsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel servicePanel;
        private System.Windows.Forms.Panel webPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TargetDirectory;
        private System.Windows.Forms.TextBox webName;
        private System.Windows.Forms.ComboBox ServerBox;
        private System.Windows.Forms.Label ProdServerSelected;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox hostFile;
        private System.Windows.Forms.TextBox HostFolder;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.Label label14;
    }
}

