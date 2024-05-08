using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Task_App
{

    public partial class TaskApp : Form
    {


        public TaskApp()
        {
            InitializeComponent();



            /// <summary>
            ///  Loop through the dictionary and concatenate its contents
            /// </summary>
            StringBuilder sb = new StringBuilder();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
        
            dgTaskList.Rows.Add(txtTaskDescription.Text, cbPriority.Text, dtFinishingDate.Value);
            string newJson = TaskToJson(txtTaskDescription.Text, cbPriority.Text, dtFinishingDate.Value);

            CreateJson(newJson);


        }

        public string  TaskToJson(string task, string priority, DateTime date)
        {
            string TaskName = task;
            string Priority = priority;
            DateTime Date = date;
            

            List<Task> dataCollection = new List<Task>();
            var data = new Task(TaskName, Priority, Date);



            dataCollection.Add(data);

            // Serialize data to JSON
            string jsonString = JsonSerializer.Serialize(dataCollection);

            return jsonString;
        }
        private void CreateJson(string jsonString) 
        {

            string getPath = CurrentPath.GetPath();

            string newPath = getPath + "taskList.json";

            // Combine the directory and file name to get the full file path
            string filePath = Path.Combine(newPath, "taskList.json");

            // Create/Write JSON string to file
            File.WriteAllText(newPath, jsonString);


        }
        public class Task
        {
            public string TaskDescription { get; set; }
            public string Priority { get; set; }
            public DateTime Date { get; set; }

             public Task(string task, string priority, DateTime date)
            {
                TaskDescription = task;
                Priority = priority;
                Date = date;
            }
        }
    }
    
}
