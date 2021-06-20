using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace LessonsTimerRealOne 
{
    class DayOfWeek : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string _firstLesson;
        public string FirstLesson
        {
            get => _firstLesson;
            set { _firstLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstLesson")); }
        }

        private TimeSpan _tfirstLesson;
        public TimeSpan tFirstLesson
        {
            get => _tfirstLesson;
            set { _tfirstLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("tFirstLesson")); }
        }

        private string _secondLesson;
        public string SecondLesson
        {
            get => _secondLesson;
            set { _secondLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SecondLesson")); }
        }

        private TimeSpan _tsecondLesson;
        public TimeSpan tSecondLesson
        {
            get => _tsecondLesson;
            set { _tsecondLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("tSecondLesson")); }
        }

        private string _thirdLesson;
        public string ThirdLesson
        {
            get => _thirdLesson;
            set { _thirdLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ThirdLesson")); }
        }
        private TimeSpan _sthirdLesson;
        public TimeSpan sThirdLesson
        {
            get => _sthirdLesson;
            set { _sthirdLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("sThirdLesson")); }
        }

        private string _fourthLesson;
        public string FourthLesson
        {
            get => _fourthLesson;
            set { _fourthLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FourthLesson")); }
        }

        private TimeSpan _sfourthLesson;
        public TimeSpan sFourthLesson
        {
            get => _sfourthLesson;
            set { _sfourthLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FourthLesson")); }
        }

        

        private string _fifthLesson;
        public string FifthLesson
        {
            get => _fifthLesson;
            set { _fifthLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FifthLesson")); }
        }

        private TimeSpan _sfifthLesson;
        public TimeSpan sFifthLesson
        {
            get => _sfifthLesson;
            set { _sfifthLesson = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("sFifthLesson")); }
        }
        public static ObservableCollection<DayOfWeek> WholeWeek { get; set; } = new ObservableCollection<DayOfWeek>();
        public static void InitDoW()
        {
            WholeWeek.Add(new DayOfWeek
            {
                Name = "Pondělí",
                FirstLesson = "Matika",
                tFirstLesson = new TimeSpan(8, 0, 0),
                SecondLesson = "Čeština",
                tSecondLesson = new TimeSpan(8, 55, 0),
                ThirdLesson = "Tělocvik",
                sThirdLesson = new TimeSpan(10, 0, 0),
                FourthLesson = "Tělocvik",
                sFourthLesson = new TimeSpan(10, 55, 0),
                FifthLesson = "Angličtina",
                sFifthLesson = new TimeSpan(11, 50, 0)
            });
            WholeWeek.Add(new DayOfWeek
            {
                Name = "Úterý",
                FirstLesson = "Matika",
                tFirstLesson = new TimeSpan(8, 0, 0),
                SecondLesson = "Čeština",
                tSecondLesson = new TimeSpan(8, 55, 0),
                ThirdLesson = "Tělocvik",
                sThirdLesson = new TimeSpan(10, 0, 0),
                FourthLesson = "Tělocvik",
                sFourthLesson = new TimeSpan(10, 55, 0),
                FifthLesson = "Angličtina",
                sFifthLesson = new TimeSpan(11, 50, 0)
            });
            WholeWeek.Add(new DayOfWeek
            {
                Name = "Středa",
                FirstLesson = "Matika",
                tFirstLesson = new TimeSpan(8, 0, 0),
                SecondLesson = "Čeština",
                tSecondLesson = new TimeSpan(8, 55, 0),
                ThirdLesson = "Tělocvik",
                sThirdLesson = new TimeSpan(10, 0, 0),
                FourthLesson = "Tělocvik",
                sFourthLesson = new TimeSpan(10, 55, 0),
                FifthLesson = "Angličtina",
                sFifthLesson = new TimeSpan(11, 50, 0)
            });
            WholeWeek.Add(new DayOfWeek
            {
                Name = "Čtvrtek",
                FirstLesson = "Matika",
                tFirstLesson = new TimeSpan(8, 0, 0),
                SecondLesson = "Čeština",
                tSecondLesson = new TimeSpan(8, 55, 0),
                ThirdLesson = "Tělocvik",
                sThirdLesson = new TimeSpan(10, 0, 0),
                FourthLesson = "Tělocvik",
                sFourthLesson = new TimeSpan(10, 55, 0),
                FifthLesson = "Angličtina",
                sFifthLesson = new TimeSpan(11, 50, 0)
            });
            WholeWeek.Add(new DayOfWeek
            {
                Name = "Pátek",
                FirstLesson = "Matika",
                tFirstLesson = new TimeSpan(8, 0, 0),
                SecondLesson = "Čeština",
                tSecondLesson = new TimeSpan(8, 55, 0),
                ThirdLesson = "Tělocvik",
                sThirdLesson = new TimeSpan(10, 0, 0),
                FourthLesson = "Tělocvik",
                sFourthLesson = new TimeSpan(10, 55, 0),
                FifthLesson = "Angličtina",
                sFifthLesson = new TimeSpan(11, 50, 0)
            });
        } 
    }
}
