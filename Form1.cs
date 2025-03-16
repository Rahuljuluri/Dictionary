namespace DD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            var My_Dictionary = new Dictionary<string, string>()
            {
                { "car", "A car is used for transport purpose." },
                { "computer", "A computer is an electronic device that processes data." },
                { "book", "A book is a set of written, printed, or blank pages fastened together." },
                { "ocean", "An ocean is a vast body of salt water covering much of the Earth's surface." },
                { "telephone", "A telephone is a device used for voice communication over long distances." },
                { "dictionary", "A dictionary is a reference book that contains words and their meanings." },
                { "school", "A school is an institution for educating children and students." },
                { "bicycle", "A bicycle is a two-wheeled vehicle that is powered by pedaling." },
                { "planet", "A planet is a celestial body orbiting a star, like Earth or Mars." },
                { "music", "Music is an art form consisting of sound and rhythm." },
                { "bridge", "A bridge is a structure built to span a physical obstacle, such as a river." },
                { "hospital", "A hospital is a place where sick or injured people receive medical care." },
                { "garden", "A garden is a plot of land used for growing flowers, vegetables, or plants." },
                { "engineer", "An engineer is a professional who applies science and math to solve problems." },
                { "moon", "The moon is Earth's only natural satellite." }
            };
             
            string words;
            words = insertBox.Text;
            try
            {
                resultBox.Text = My_Dictionary[words];
            }
            catch
            {
                resultBox.Text = "Sorry! word not Founded";

            }

        }
    }
}
