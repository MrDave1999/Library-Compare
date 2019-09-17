using System;

namespace sCompare
{
    public class SCompare
    {
        private string str1;
        private int i;
        private bool ignorecase = true;

        public SCompare(string str1)
        {
            this.str1 = str1;
        }

        public SCompare(bool ignorecase)
        {
            this.ignorecase = ignorecase;
        }

        public SCompare(string str1, bool ignorecase)
        {
            this.str1 = str1;
            this.ignorecase = ignorecase;
        }

        public SCompare()
        {

        }

        public bool IgnoreCase
        {
            get { return ignorecase; }
            set { ignorecase = value; }
        }

        public string Strin
        {
            get { return str1; }
            set { str1 = value; }
        }

        public static bool operator ==(SCompare s, string s2)
        {

            return s.strcmp(s2) ? (true) : (false);
        }

        public static bool operator !=(SCompare s, string s2)
        {
            return true;
        }

        public override bool Equals(object o)
        {
            return base.Equals(o);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private bool charcmp(char c2, char l2)
        {
            return !(str1[i] == c2 || c2 == l2) ? (false) : (true);
        }

        private bool strcmp(string str2)
        {
            if (str1.Length != str2.Length) return false;
            if (!ignorecase)
            {
                for (i = str1.Length - 1; i != -1; --i)
                    if (!(str1[i] == str2[i])) return false;
                return true;
            }
            for (i = str1.Length - 1; i != -1; --i)
            {
                switch (str1[i])
                {
                    /* Vocales con acento agudo */
                    case 'á':
                        if (!charcmp(str2[i], 'Á')) return false;
                        break;
                    case 'é':
                        if (!charcmp(str2[i], 'É')) return false;
                        break;
                    case 'í':
                        if (!charcmp(str2[i], 'Í')) return false;
                        break;
                    case 'ó':
                        if (!charcmp(str2[i], 'Ó')) return false;
                        break;
                    case 'ú':
                        if (!charcmp(str2[i], 'Ú')) return false;
                        break;
                    case 'Á':
                        if (!charcmp(str2[i], 'á')) return false;
                        break;
                    case 'É':
                        if (!charcmp(str2[i], 'é')) return false;
                        break;
                    case 'Í':
                        if (!charcmp(str2[i], 'í')) return false;
                        break;
                    case 'Ó':
                        if (!charcmp(str2[i], 'ó')) return false;
                        break;
                    case 'Ú':
                        if (!charcmp(str2[i], 'ú')) return false;
                        break;

                    /* Vocales con acento grave*/
                    case 'à':
                        if (!charcmp(str2[i], 'À')) return false;
                        break;
                    case 'è':
                        if (!charcmp(str2[i], 'È')) return false;
                        break;
                    case 'ì':
                        if (!charcmp(str2[i], 'Ì')) return false;
                        break;
                    case 'ò':
                        if (!charcmp(str2[i], 'Ò')) return false;
                        break;
                    case 'ù':
                        if (!charcmp(str2[i], 'Ù')) return false;
                        break;
                    case 'À':
                        if (!charcmp(str2[i], 'à')) return false;
                        break;
                    case 'È':
                        if (!charcmp(str2[i], 'è')) return false;
                        break;
                    case 'Ì':
                        if (!charcmp(str2[i], 'ì')) return false;
                        break;
                    case 'Ò':
                        if (!charcmp(str2[i], 'ò')) return false;
                        break;
                    case 'Ù':
                        if (!charcmp(str2[i], 'ù')) return false;
                        break;

                    case 'ñ':
                        if (!charcmp(str2[i], 'Ñ')) return false;
                        break;
                    case 'Ñ':
                        if (!charcmp(str2[i], 'ñ')) return false;
                        break;

                    default:
                        {
                            if (!(str1[i] == str2[i] || str1[i] + 32 == str2[i] || str1[i] - 32 == str2[i])) return false;
                            break;
                        }
                }
            }
            return true;
        }
    }
}
