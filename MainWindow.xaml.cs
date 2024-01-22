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

            Anzeige( "Init ... ok" );

        }   // end: public MainWindow

        /// <summary>
        /// handlerfunction -> Window_Closing
        /// </summary>
        /// <param name="sender">triggering UI-element</param>
        /// <param name="e">send parameter from it</param>
        private void Window_Closing( object sender, System.ComponentModel.CancelEventArgs e )
        {

        }

        /// <summary>
        /// handlerfunction -> MenuItem
        /// </summary>
        /// <param name="sender">triggering UI-element</param>
        /// <param name="e">send parameter from it</param>
        private void MenuQuit_Click( object sender, RoutedEventArgs e )
        {
            this.Close();

        }   // Ende: MenuQuit_Click

        /// <summary>
        /// helperfunction, writng arraydata into a string
        /// </summary>
        /// <param name="data">2d ragged array </param>
        /// <returns>the data as string</returns>
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

        }   // end: ArrayToString

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
