using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMachine_ExerciceGit
{
    public class QuoteManager
    {
        private List<Quote> _quotes;

        public QuoteManager()
        {
            _quotes = new List<Quote>
            {
                new Quote { Text = "Le succès, c’est d’aller d’échec en échec sans perdre son enthousiasme.", Author = "Winston Churchill" },
                new Quote { Text = "Soyez vous-même, tous les autres sont déjà pris.", Author = "Oscar Wilde" },
                new Quote { Text = "La vie, c’est comme une bicyclette, il faut avancer pour ne pas perdre l’équilibre.", Author = "Albert Einstein" }
            };
        }

        public Quote GetRandomQuote()
        {
            //Avant de commencer, décommenter le test suivant:
            //GetRandomQuote_ShouldReturnNonNullQuote

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            throw new NotImplementedException("À implémenter dans feature/random-quote");
        }

        public void AddQuote(string text, string author)
        {
            //Avant de commencer, décommenter le test suivant:
            //AddQuote_ShouldIncreaseQuoteCount

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            throw new NotImplementedException("À implémenter dans feature/add-quote");
        }

        public void SaveToCSVFile(string path)
        {
            //Avant de commencer, décommenter les tests suivants:
            //SaveToFile_ShouldCreateFile
            //SaveToFile_ShouldThrowIfNotInCSVExtension

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            throw new NotImplementedException("À implémenter dans feature/save-to-file");
        }

        public void LoadFromCSVFile(string path)
        {
            if (!IsCSVFile(path))
            {
                throw new QuoteFileException("Erreur lors de la sauvegarde : le fichier doit avoir l'extension .csv");
            }

            if (!File.Exists(path))
            {
                throw new QuoteFileException("Erreur lors du chargement : le fichier n'existe pas");
            }

            //https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    _quotes.Add(new Quote() { Text = values[0], Author = values[1] });
                }
            }
        }

        public List<Quote> GetAllQuotes()
        {
            return _quotes;
        }

        private bool IsCSVFile(string path)
        {
            return path.EndsWith(".csv");
        }
    }
}
