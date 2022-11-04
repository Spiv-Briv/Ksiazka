using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace RatujLudzi
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        DispatcherTimer targetTimer = new DispatcherTimer();
        bool humanCap = false;
        public MainPage()
        {
            this.InitializeComponent();
            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);
            targetTimer.Tick += TargetTimer_Tick;
            targetTimer.Interval = TimeSpan.FromSeconds(.1);
        }

        private void TargetTimer_Tick(object sender, object e)
        {
            progress.Value += 1;
            if(progress.Value >= progress.Maximum)
            {
                EndTheGame();
            }
        }

        private void EnemyTimer_Tick(object sender, object e)
        {
            addEnemy();
        }
        private void Pointer(object sender, PointerRoutedEventArgs e)
        {
            if (enemyTimer.IsEnabled)
            {
                humanCap = true;
                human.IsHitTestVisible = false;
            }
        }
        private void PEnter(object sender, PointerRoutedEventArgs e)
        {
            if(targetTimer.IsEnabled && humanCap)
            {
                progress.Value = 0;
                Canvas.SetLeft(target, random.Next(100,(int)playArea.ActualWidth-100));
                Canvas.SetTop(target, random.Next(100, (int)playArea.ActualHeight-100));
                Canvas.SetLeft(human, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(human, random.Next(100, (int)playArea.ActualHeight - 100));
                humanCap = false;
                human.IsHitTestVisible = true;
            }
        }
        private void PMoved(object sender, PointerRoutedEventArgs e)
        {
            if (humanCap)
            {
                Point point = e.GetCurrentPoint(null).Position;
                Point relPoint = grid.TransformToVisual(playArea).TransformPoint(point);
                if((Math.Abs(relPoint.X - Canvas.GetLeft(human)) > human.ActualWidth * 3) || (Math.Abs(relPoint.Y - Canvas.GetTop(human)) > human.ActualHeight * 3))
                {
                    humanCap = false;
                    human.IsHitTestVisible = true;
                }
                else
                {
                    Canvas.SetLeft(human, relPoint.X - human.ActualWidth / 2);
                    Canvas.SetTop(human, relPoint.Y - human.ActualHeight / 2);
                }
            }
        }
        private void Pexit(object sender, PointerRoutedEventArgs e)
        {
            if (humanCap)
            {
                EndTheGame();
            }
        }
        private void EPEnter(object sender, PointerRoutedEventArgs e)
        {
            if (humanCap)
            {
                EndTheGame();
            }
        }
        public void Zacznij(object sender, RoutedEventArgs e)
        {
            human.IsHitTestVisible = true;
            humanCap = false;
            progress.Value = 0;
            Start.Visibility = Visibility.Collapsed;
            playArea.Children.Clear();
            playArea.Children.Add(target);
            playArea.Children.Add(human);
            enemyTimer.Start();
            targetTimer.Start();
        }

        private void addEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, playArea.ActualWidth - 100, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)playArea.ActualHeight-100), random.Next((int)playArea.ActualHeight - 100), "(Canvas.Top)");
            playArea.Children.Add(enemy);
            enemy.PointerEntered += EPEnter;
        }
        private void AnimateEnemy(ContentControl enemy, double from, double to, string propertyToAnimate)
        {
            Storyboard story = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation ani = new DoubleAnimation() { From = from, To = to, Duration = new Duration(TimeSpan.FromSeconds(random.Next(4, 6))) };
            Storyboard.SetTarget(ani, enemy);
            Storyboard.SetTargetProperty(ani, propertyToAnimate);
            story.Children.Add(ani);
            story.Begin();
        }
        private void EndTheGame()
        {
            enemyTimer.Stop();
            targetTimer.Stop();
            humanCap = false;
            Start.Visibility = Visibility.Visible;
            playArea.Children.Add(GameOverText);
        }
    }
}
