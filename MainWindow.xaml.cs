using System.Windows;

namespace EmptyWPFwithScroll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        public MainWindow( )
        {
            InitializeComponent();

            Anzeige( "Init ... ok" );

        }

        /// <summary>
        /// Handlerfunktion -> Window_Closing
        /// </summary>
        /// <param name="sender">auslösendes Oberflächenelement</param>
        /// <param name="e">Übergabeparameter davon</param>
        private void Window_Closing( object sender, System.ComponentModel.CancelEventArgs e )
        {

        }

        /// <summary>
        /// Handlerfunktion -> MenuItem
        /// </summary>
        /// <param name="sender">auslösendes Oberflächenelement</param>
        /// <param name="e">Übergabeparameter davon</param>
        private void MenuQuit_Click( object sender, RoutedEventArgs e )
        {
            this.Close();

        }   // Ende: MenuQuit_Click

        /// <summary>
        /// Hilfsfunktion, die die Datenfelder in einen String schreibt.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Die Daten als String</returns>
        public string ArrayToString( double[][] data, bool umbruch = false )
        {
            string text = "";

            foreach ( double[] dat in data )
            {
                text += $" [ {string.Join( ", ", dat )} ] ";
                if ( umbruch )
                    text += "\n";

            }
            text += "\n";
            return ( text );

        }   // Ende: ArrayToString

        /// <summary>
        /// Hilfsfunktion, die den übergebenen Text in die 
        /// Textausgabe schreibt.
        /// </summary>
        /// <param name="text">Eingabestring</param>
        public void Anzeige( string? text )
        {
            if ( !string.IsNullOrEmpty( text ) )
                textBlock.Text += text + "\n";
            textScroll.ScrollToBottom();

        }   // Ende: Anzeige

        /// <summary>
        /// Hilfsfunktion, die den übergebenen Text in die 
        /// Textausgabe schreibt.
        /// </summary>
        /// <param name="text">Any-Objekt-Variante</param>
        private void Anzeige( int obj )
        {
            Anzeige( obj.ToString() );

        }   // Ende: Anzeige

    }   // Ende: class MainWindow

}   // Ende: namespace EmptyWPFwithScroll
