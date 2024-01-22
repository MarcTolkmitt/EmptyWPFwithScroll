using System.Windows;

namespace EmptyWPFwithScroll
{
    /// <summary>
    /// interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// standardconstructor
        /// </summary>
        public MainWindow( )
        {
            InitializeComponent();

            Display( "Init ... ok" );

        }   // end: public MainWindow

        /// <summary>
        /// handlerfunction -> Window_Closing
        /// </summary>
        /// <param name="sender">triggering UI-element</param>
        /// <param name="e">send parameter from it</param>
        private void Window_Closing( object sender, System.ComponentModel.CancelEventArgs e )
        {

        }   // end: private void Window_Closing

        /// <summary>
        /// handlerfunction -> MenuItem
        /// used for exitroutines
        /// </summary>
        /// <param name="sender">triggering UI-element</param>
        /// <param name="e">send parameter from it</param>
        private void MenuQuit_Click( object sender, RoutedEventArgs e )
        {
            this.Close();

        }   // end: MenuQuit_Click



        // ---------------------------------------------     helperfunctions

        /// <summary>
        /// helperfunction, writing arraydata into a string
        /// </summary>
        /// <param name="data">2d ragged array </param>
        /// <returns>the data as string</returns>
        public string ArrayToString( double[][] data, bool textWrap = false )
        {
            string text = "";

            foreach ( double[] dat in data )
            {
                text += $" [ {string.Join( ", ", dat )} ] ";
                if ( textWrap )
                    text += "\n";

            }
            text += "\n";
            return ( text );

        }   // end: ArrayToString

        /// <summary>
        /// helperfunction to write the text into the mainwindow
        /// </summary>
        /// <param name="text">inputstring</param>
        public void Display( string? text )
        {
            if ( !string.IsNullOrEmpty( text ) )
                textBlock.Text += text + "\n";
            textScroll.ScrollToBottom();

        }   // end: Display

        /// <summary>
        /// helperfunction to write the text into the mainwindow
        /// </summary>
        /// <param name="text">any-objekt-variant</param>
        private void Display( int obj )
        {
            Display( obj.ToString() );

        }   // end: Display

    }   // end: class MainWindow

}   // end: namespace EmptyWPFwithScroll
