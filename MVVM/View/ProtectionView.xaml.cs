using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KoalaVPN.MVVM.ViewModel;

namespace KoalaVPN.MVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ProtectionView : UserControl
    {
        public ProtectionView()
        {
            InitializeComponent();
        }
        private string _address;
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public void SelectedServer(object sender, SelectionChangedEventArgs e)
        {
            ServerModel _selectedServer = (ServerModel)list1.SelectedItem;
            address = _selectedServer.ServerAddress;
            MessageBox.Show("Connecting to server : " + _selectedServer.Country);
            ServerBuilder();
        }
        public void ServerBuilder()
        {
            //MessageBox.Show(address);
            var FolderPath = $"{Directory.GetCurrentDirectory()}/VPN";
            var PbkPath = $"{FolderPath}/VPN.pbk";
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            var sb = new StringBuilder();
            sb.AppendLine("[MyServer]");
            sb.AppendLine("MEDIA=rastapi");
            sb.AppendLine("Port=VPN2-0");
            sb.AppendLine("Device=WAN Miniport(IKEv2)");
            sb.AppendLine("DEVICE=VPN");
            sb.AppendLine($"PhoneNumber={address}");
            File.WriteAllText(PbkPath, sb.ToString());
        }
    }
}
