namespace WinFormsApp1
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    folderPathTextBox.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = folderPathTextBox.Text;

            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("请输入有效的文件夹路径。");
                return;
            }

            string[] specificFileNames = { "NativeTrainerConfig.xml", "ScriptHookV.dll", "TrainerV.asi", "trainerv.ini", "NativeTrainer.asi", "dinput8.dll" }; // 存储要删除的特定文件的名称

            try
            {
                foreach (string fileName in specificFileNames)
                {
                    string filePath = Path.Combine(folderPath, fileName);

                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }

                MessageBox.Show("指定名称的文件删除成功。");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除文件时出现错误：{ex.Message}");
            }
        }
    }
}