using ATMDemoProject_MVVM.Command;
using ATMDemoProject_MVVM.Models;
using ATMDemoProject_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ATMDemoProject_MVVM.ViewModel
{
    public class ATMInfoViewModel : INotifyPropertyChanged
    {
        ATMContext db = null;
        ObservableCollection<CardInformation> cardDetailsList = null;
        ObservableCollection<AccountDetails> accountDetailsList = null;


        private CardInformation cardInformationObj = new CardInformation();
        private AccountDetails accountDetailsObj = new AccountDetails();


        public string UI_CardNumber
        {
            get { return cardInformationObj.CardNumber; }
            set
            {
                if (value != string.Empty)
                {
                    cardInformationObj.CardNumber =value;
                    OnPropertyChanged("UI_CardNumber");
                }
            }
        }

        public string UI_UserName
        {
            get { return cardInformationObj.UserName; }
            set
            {
                if (value != string.Empty)
                {
                    cardInformationObj.UserName = value;
                    OnPropertyChanged("UI_UserName");
                }
            }
        }

        public string UI_Pin
        {
            get { return cardInformationObj.Pin.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    cardInformationObj.Pin = Convert.ToInt32(value);
                    OnPropertyChanged("UI_Pin");
                }
            }
        }

        public string UI_AccountBalance
        {
            get { return accountDetailsObj.AccountBalance.ToString(); }
            set
            {
                accountDetailsObj.AccountBalance = Convert.ToInt32(value);
                OnPropertyChanged("UI_AccountBalance");
            }
        }


        public string UI_TransactionDate
        {
            get { return accountDetailsObj.TransactionDate.ToString(); }
            set
            {
                accountDetailsObj.TransactionDate = Convert.ToDateTime(value);
                OnPropertyChanged(UI_TransactionDate);
            }

        }


        //public string UI_ADCArdNumber
        //{
        //    get { return accountDetailsObj.CardNumber.ToString(); }
        //    set
        //    {
        //        accountDetailsObj.CardNumber = Convert.ToInt32(value);
        //        OnPropertyChanged(UI_ADCArdNumber);
        //    }
        //}

        public ObservableCollection<CardInformation> CardDetailsList
        {
            get { return cardDetailsList; }
            set
            {
                cardDetailsList = value;
                OnPropertyChanged("CardDetailsList");
            }
        }


        public void Transaction(object obj)
        {
            TransactionOperation transactionOperation = new TransactionOperation();
            transactionOperation.Show();
        }
       
        public ICommand LoginCommand { get;  }

        public ICommand CheckBalanceCommand { get; }

        public ICommand MiniStatementCommand { get; }


        public bool CanLogin(object obj)
        {
            if ((this.UI_CardNumber != null) && (this.UI_Pin != null))
            {
                return true;
            }
            return false;
        }



        public void Login(object obj)
        {
           
            int Pin = int.Parse(this.UI_Pin);


            CardInformation cardInformation = db.CardInformation.FirstOrDefault(c => c.CardNumber == UI_CardNumber && c.Pin == Pin);

            if (cardInformation != null)
            {

                TransactionOperation transactionOperation = new TransactionOperation();
                transactionOperation.Show();
                MessageBox.Show("Hello User");
            }
            else
            {
                MessageBox.Show("User is not valid ");
            }

        }

        public void CheckBal(object obj)
        {
            
            AccountDetails accountDetails = db.AccountDetails.Where(a => a.CardNumber == UI_CardNumber).OrderByDescending(a=>a.TransactionDate).FirstOrDefault();
            CheckBalanceForm checkBalanceForm = new CheckBalanceForm();
            if (accountDetails != null)
            {
                this.UI_AccountBalance = accountDetails.AccountBalance.ToString();
            }
            checkBalanceForm.Show();
        }

        public void MiniState(object obj)
        {
            
            List<AccountDetails> accountDetails = db.AccountDetails.Where(a => a.CardNumber == UI_CardNumber).OrderByDescending(a => a.TransactionDate).ToList();
            StatementForm statementForm = new StatementForm();
            statementForm.Show();
        }
        public ATMInfoViewModel()
        {
            db = new ATMContext();
            LoginCommand = new RelayCommand(Login, CanLogin);
            CheckBalanceCommand = new RelayCommand(CheckBal);
            MiniStatementCommand = new RelayCommand(MiniState);


        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {



            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}

