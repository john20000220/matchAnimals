using System;
using System.Collections.Generic;
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

namespace matchAnimals
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()//建立一個有8對Emoji的List
            {
                "🦁","🦁",
                "🐱","🐱",
                "🐺","🐺",
                "🐶","🐶",
                "🐯","🐯",
                "🦊","🦊",
                "🦝","🦝",
                "🐷","🐷",
            };

            Random random = new Random();//建立新的隨機數產生器

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())//找出主格線的每一個TextBlock，並且為每一個TextBlock重複接下來的陳述式
            {
                int index = random.Next(animalEmoji.Count);//在0與List剩餘的emoji數量之間隨機選擇一個數字，並將它稱為index
                string nextEmoji = animalEmoji[index];//使用稱為index的隨機數，從List隨機取出一個Emoji
                textBlock.Text = nextEmoji;//用List裡面的隨機Emoji來更新TextBlock
                animalEmoji.RemoveAt(index);//將List裡面的隨機emoji刪除
            }
        }
    }
}
