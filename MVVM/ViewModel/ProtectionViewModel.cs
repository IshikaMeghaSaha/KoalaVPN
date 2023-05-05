using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using KoalaVPN.Core;
using KoalaVPN.MVVM.View;
using System.Windows.Controls;

namespace KoalaVPN.MVVM.ViewModel
{
    public class ProtectionViewModel : ObservableObject
    {
        public ObservableCollection<ServerModel> Servers { get; set; }
        private string _connectionStatus;
        public string ConnectionStatus
        {
            get { return _connectionStatus; }
            set
            {
                _connectionStatus = value;
                OnPropertyChanged();
            }
        }
        private string _connectButtonStatus = "Connect";
        public string ConnectButtonStatus
        {
            get { return _connectButtonStatus; }
            set
            {
                _connectButtonStatus = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand ConnectCommand { get; set; }
        public ProtectionViewModel()
        {
            Servers = new ObservableCollection<ServerModel>();
            Servers.Add(new ServerModel
            {
                Country = "USA 1",
                Image = "https://i.imgur.com/tX2FzGr.png",
                ServerAddress = "us1.vpnbook.com"
            });
            Servers.Add(new ServerModel
            {
                Country = "USA 2",
                Image = "https://i.imgur.com/tX2FzGr.png",
                ServerAddress = "us2.vpnbook.com"
            });
            Servers.Add(new ServerModel
            {
                Country = "France 1",
                Image = "https://i.imgur.com/r0v4Jkp.png",
                ServerAddress = "fr1.vpnbook.com"
            });
            Servers.Add(new ServerModel
            {
                Country = "France 2",
                Image = "https://i.imgur.com/r0v4Jkp.png",
                ServerAddress = "fr8.vpnbook.com"
            });
            Servers.Add(new ServerModel
            {
                Country = "Canada 1",
                Image = "https://i.imgur.com/jx8KRqh.png",
                ServerAddress = "ca222.vpnbook.com"
            });
            Servers.Add(new ServerModel
            {
                Country = "Canada 2",
                Image = "https://i.imgur.com/jx8KRqh.png",
                ServerAddress = "ca198.vpnbook.com"
            });
            Servers.Add(new ServerModel
            {
                Country = "Poland",
                Image = "https://i.imgur.com/lifJoKu.png",
                ServerAddress = "PL226.vpnbook.com"
            });
            Servers.Add(new ServerModel
            {
                Country = "Germany",
                Image = "https://i.imgur.com/bhZ7aBe.png",
                ServerAddress = "DE4.vpnbook.com"
            });

            ConnectCommand = new RelayCommand(o =>
            {
                Task.Run(() =>
                {
                    if (ConnectButtonStatus == "Connect")
                    {

                        ConnectionStatus = "Connecting...";
                        var process = new Process();
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                        process.StartInfo.ArgumentList.Add(@"/c rasdial MyServer vpnbook 3ev7r8m /phonebook:./VPN/VPN.pbk");
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                        process.WaitForExit();
                        switch (process.ExitCode)
                        {
                            case 0:
                                Debug.WriteLine("Success");
                                ConnectionStatus = "Connected";
                                ConnectButtonStatus = "Disconnect";
                                break;
                            case 691:
                                Debug.WriteLine("Wrong Credentials");
                                ConnectionStatus = "Wrong Credentials";
                                break;
                            default:
                                Debug.WriteLine($"Error : {process.ExitCode}");
                                ConnectionStatus = "Retry";
                                MessageBox.Show(process.ExitCode.ToString());

                                break;
                        }
                    }
                    else
                    {
                        ConnectionStatus = "Disconnecting...";
                        var process = new Process();
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                        process.StartInfo.ArgumentList.Add(@"/c rasdial /d");
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                        process.WaitForExit();
                        ConnectionStatus = "Disconnected";
                        ConnectButtonStatus = "Connect";
                        File.Delete("./VPN/VPN.pbk");
                    }
                });
            });

        }

    }
}