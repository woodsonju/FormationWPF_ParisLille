using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1Window.BindingTest.Model
{
    public class User : INotifyPropertyChanged
    {
        //Premiere et deuxième etape
        /*public string Name { get; set; }*/


        //Troisième étape : 
        //Par convention de nommage on préfixe les champs d'un underscore(_)
        private string _name;

        public string Name
        {
            get { return _name; }

            set 
            { 
                _name = value;
                //Méthode appelée chaque fois que la propriété Name est mise à jour
                this.NotityPropertyChanged("Name");
            }
        }

        //Permet de créeer automatiquement un évenement : PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Méthode appelée  par le setter de la propriété Name
        /// </summary>
        /// <param name="propertyChanged"> Nom de la propriété qui a été modifiée</param>
        private void NotityPropertyChanged(string propertyChanged)
        {
            //On verifie si l'événement est nul ou non, sinon nous continuons
            if(this.PropertyChanged != null)
            {
                //On execute cet évenement en passant le nom de la propriété
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyChanged));
            }
        }

    }
}
