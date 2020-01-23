using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfViewer
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Stream docStream;
        
        public Stream DocumentStream
        {
            get
            {
                return docStream;
            }
            set
            {
                docStream = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DocumentStream"));
            }
        }

        public ViewModel()
        {
            //Load the stream from the local system.
            docStream = new FileStream(@"..\..\PDF_Succinctly.pdf", FileMode.OpenOrCreate);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }
}
