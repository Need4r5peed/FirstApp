using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Module8.Unit4.Task841
{

    [Serializable]
    public class Contact_Task841
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact_Task841(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void Serialized(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(PhoneNumber);
            writer.Write(Email);
        }

        public static Contact_Task841 DeSerialized(BinaryReader reader)
        {
            string name = reader.ReadString();
            long phoneNumber = reader.ReadInt64();
            string email = reader.ToString();
            return new Contact_Task841(name, phoneNumber, email);
        }
    }

    public class Main_Task841
    {
        //const string SettingsFileName = "Settings.cfg";
        const string SettingsFileName = @"C:\\Users\\Администратор\\Desktop\\BinaryFile.bin";

        public static void Main()
        {
            ////// Пишем
            ////WriteValues();
            ////// Считываем
            ////ReadValues();

            //ReadValuesMyFile();

            // Объект для сериализации
            var contact = new Contact_Task841("Иван Петров", 79884534509, "ivanpetrov@skillfactory.ru");
            Console.WriteLine($"Контакт под именем {contact.Name} создан");

            using (FileStream fileStream = new FileStream("contact.bin", FileMode.Create))
            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                contact.Serialized(binaryWriter);
                Console.WriteLine($"Контакт под именем {contact.Name} сериализован");
            }

            Contact_Task841 deserializedContact;
            using (FileStream fileStream = new FileStream("contact.bin", FileMode.Create))
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                deserializedContact = Contact_Task841.DeSerialized(binaryReader);
            }

            Console.WriteLine("Программа завершена...");
        }

        static void ReadValuesMyFile()
        {
            string StringValue;

            if (File.Exists(SettingsFileName))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных
                    StringValue = reader.ReadString();
                }

                Console.WriteLine("Из файла считано:");

                Console.WriteLine("Строка: " + StringValue);
            }
        }

        static void WriteValues()
        {
            // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
            {
                // Записываем данные в разном формате
                writer.Write(20.666F);
                writer.Write("Тестовая строка");
                writer.Write(55);
                writer.Write(false);
            }
        }

        static void ReadValues()
        {
            float FloatValue;
            string StringValue;
            int IntValue;
            bool BooleanValue;

            if (File.Exists(SettingsFileName))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных
                    FloatValue = reader.ReadSingle();
                    StringValue = reader.ReadString();
                    IntValue = reader.ReadInt32();
                    BooleanValue = reader.ReadBoolean();
                }

                Console.WriteLine("Из файла считано:");

                Console.WriteLine("Дробь: " + FloatValue);
                Console.WriteLine("Строка: " + StringValue);
                Console.WriteLine("Целое: " + IntValue);
                Console.WriteLine("Булево значение: " + BooleanValue);
            }
        }
    }
}
