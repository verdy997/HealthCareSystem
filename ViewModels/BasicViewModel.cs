using HealthCareSystem.Commands;
using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HealthCareSystem.ViewModels
{
    class BasicViewModel : ViewModelBase
    {
        public Ambulance Ambulance { get; set; }
        public Doctor Doctor { get; set; }
        public PatiensListCommand ShowPatiensList { get; }
        public DbContextViewModel Context { get; set; }
        //public ICommand ShowWaitingRoom { get; }
        public ShowArchiveCommand ShowArchive { get; }
        public BasicViewModel(Ambulance ambulance, Doctor doctor, DbContextViewModel context)
        {
            Ambulance = ambulance;
            Doctor = doctor; 
            Context = context;
            ShowPatiensList = new PatiensListCommand();
            ShowPatiensList.Ambulance = Ambulance;
            ShowPatiensList.Doctor = Doctor;
            ShowPatiensList.Context = Context;
            //ShowWaitingRoom = new WaitingRoomCommand();
            ShowArchive = new ShowArchiveCommand();
            ShowArchive.Ambulance = Ambulance;
            ShowArchive.Doctor = Doctor;
            ShowArchive.Context = Context;
        }

    }
}
