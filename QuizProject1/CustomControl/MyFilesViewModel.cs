﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace QuizProject1.CustomControl
{
    class MyFilesViewModel
    {
        //Resource Dictionary 
        public ObservableCollection<GetFileDetails> getFileDetails
        {
            get
            {
                return new ObservableCollection<GetFileDetails> {
            new GetFileDetails(){  FileName="File 1", Fill="Red", FileProgram="Adobe Acrobat", ModifiedOn="12.01.2020", FileType=".pdf"},
            new GetFileDetails(){ FileName="File 2", Fill="Green", FileProgram="Photo Viewer", ModifiedOn="18.02.2020", FileType=".png"},
            new GetFileDetails(){  FileName="File 3", Fill="CadetBlue", FileProgram="Notepad", ModifiedOn="15.07.2020", FileType=".txt"},
            new GetFileDetails(){  FileName="File 4", Fill="Green", FileProgram="Adobe Acrobat", ModifiedOn="22.07.2020", FileType=".pdf"}
            };
            }
        }
    }

    class GetFileDetails
    {
        public PathGeometry FileThumb { get; set; }
        public string Fill { get; set; }
        public string FileName { get; set; }
        public string FileProgram { get; set; }
        public string ModifiedOn { get; set; }
        public string FileType { get; set; }
    }
}
