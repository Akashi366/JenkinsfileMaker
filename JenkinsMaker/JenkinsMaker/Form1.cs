using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JenkinsMaker
{
    public partial class Form1 : Form
    {
        private int progression = 0;
        private string ProjectName = "";
        private string SolutionPath = "";
        private string HasWebApplication = "false";
        private string HasServiceLibrary = "false";
        private string folderName = @"c:\JenkinsFileMaker";
        string path = @"c:\JenkinsFileMaker\ServerList.txt";

        private string WebProjectName = "";
        private string ServiceName = "";
        private string hostFolder = "";
        private string hostexec = "";
        List<Servers> servers = new List<Servers>();

        public Form1()
        {
            System.IO.Directory.CreateDirectory(folderName);
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Développement,\\\\dev.example.fr,Serveur_Développement");
                    sw.WriteLine("Recette,\\\\rec.example.fr,Serveur_Recette");
                    sw.WriteLine("Production,\\\\prod.example.fr,Serveur_Production");
                    sw.WriteLine("ProductionService,\\\\Host.example.fr,Serveur_Production");
                }
            }

            List<string> lines = File.ReadAllLines(path).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Servers newServer = new Servers();
                newServer.ServerName = entries[0];
                newServer.ServerPath = entries[1];
                newServer.ServerType = entries[2];

                servers.Add(newServer);
            }

            InitializeComponent();

            foreach (var server in servers)
            {
                listView1.Items.Add($"{ server.ServerName } { server.ServerPath } { server.ServerType }");
                if (server.ServerType == "Serveur_Production")
                {
                    ServerBox.Items.Add($"{ server.ServerName }");
                    comboBox1.Items.Add($"{ server.ServerName }");
                }
            }

            CreateButton.Enabled = false;
            button3.Enabled = false;
            paramsBox.Visible = false;
            groupBox2.Visible = false;
            TargetDirectory.Text = "C:\\\\JenkinsfileMaker\\";
            ProdServerSelected.Text = "";
            label14.Text = "";
        }

        private void paramsButton_Click(object sender, EventArgs e)
        {
            paramsBox.Visible = true;
            button2.Enabled = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            paramsBox.Visible = false;
            button2.Enabled = true;
        }

        private void projectName_TextChanged(object sender, EventArgs e)
        {
            ProjectName = projectName.Text;
            TargetDirectory.Text = "C:\\\\JenkinsfileMaker\\" + projectName.Text;
        }

        private void solutionPath_TextChanged(object sender, EventArgs e)
        {
            SolutionPath = solutionPath.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                HasWebApplication = "true";
            }
            else
            {
                HasWebApplication = "false";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                HasServiceLibrary = "true";
            }
            else
            {
                HasServiceLibrary = "false";
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (ProjectName != "")
            {
                System.IO.Directory.CreateDirectory("c:\\JenkinsFileMaker\\" + ProjectName);
                System.IO.Directory.CreateDirectory("c:\\JenkinsFileMaker\\" + ProjectName + "\\WorkBranch");
                if (!File.Exists("c:\\JenkinsFileMaker\\" + ProjectName + "\\WorkBranch\\Jenkinsfile"))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText("c:\\JenkinsFileMaker\\" + ProjectName + "\\WorkBranch\\Jenkinsfile"))
                    {
                        sw.WriteLine("Hello");
                        sw.WriteLine("And");
                        sw.WriteLine("Welcome");
                    }
                }
                System.IO.Directory.CreateDirectory("c:\\JenkinsFileMaker\\" + ProjectName + "\\MasterBranch");
                System.IO.Directory.CreateDirectory("c:\\JenkinsFileMaker\\" + ProjectName + "\\ProductionBranch");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progression == 0)
            {
                groupBox2.Visible = true;
                button2.Enabled = false;
                CreateButton.Enabled = false;
                button3.Enabled = true;
                progression += 1;
            }
            if (HasWebApplication == "true")
            {
                webPanel.Visible = true;
                CreateButton.Enabled = true;
            } 
            else
            {
                webPanel.Visible = false;
            }
            if (HasServiceLibrary == "true")
            {
                servicePanel.Visible = true;
                CreateButton.Enabled = true;
            }
            else
            {
                servicePanel.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progression == 1)
            {
                groupBox2.Visible = false;
                button2.Enabled = true;
                CreateButton.Enabled = false;
                button3.Enabled = false;
                progression -= 1;
            }
        }

        private void webName_TextChanged(object sender, EventArgs e)
        {
            WebProjectName = webName.Text;
        }

        private void ServerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var server in servers)
            {
                if (server.ServerName == ServerBox.Text)
                {
                    ProdServerSelected.Text = server.ServerPath;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var server in servers)
            {
                if (server.ServerName == comboBox1.Text)
                {
                    label14.Text = server.ServerPath;
                }
            }
        }

        private void serviceName_TextChanged(object sender, EventArgs e)
        {
            ServiceName = serviceName.Text;
        }

        private void HostFolder_TextChanged(object sender, EventArgs e)
        {
            hostFolder = HostFolder.Text;
        }

        private void hostFile_TextChanged(object sender, EventArgs e)
        {
            hostexec = hostFile.Text;
        }
    }
}
