using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoAPIApp
{
    public partial class UserControlPlayfair : UserControl
    {
        public UserControlPlayfair()
        {
            InitializeComponent();
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            String str = textboxplaintext.Text.ToString();

            Invoke(new Action(() => textboxencrypted.Clear()));
            Invoke(new Action(() => textboxencrypted.AppendText(PlayFair_encrypt(str))));
            if (textboxkey.Text == "") return;


        }

        String PlayFair_encrypt(String str)
        {

            
            //convert the whole message into capital letters .. because  the matrix is capital letters
            StringBuilder tmp_str = new StringBuilder(str.ToUpper());
            //implement the encryption

            //we'll need to remove all the spaces between the word so we need to store their indexes
            //inorder to place them again after the encryption is done
            int[] space_indexes = new int[20];
            int space_count = 0;

            //first we remove any space in the message
            for (int count1 = 0; count1 < tmp_str.Length; count1 += 1)
            {

                if (tmp_str[count1] == ' ')
                {
                    tmp_str = tmp_str.Remove(count1, 1);
                    space_indexes[space_count] = count1;
                    space_count++;
                }

            }
            space_indexes[space_count] = -1; // assign the end of the spaces by putting the last element 
            //with -1

            //then we change every 'j' character into 'i' character(because they are stored in the same element
            for (int count1 = 0; count1 < tmp_str.Length; count1 += 1)
            {

                if (tmp_str[count1] == 'j')
                {
                    tmp_str[count1] = 'i';
                }

                if (tmp_str[count1] == 'J')
                {
                    tmp_str[count1] = 'I';
                }

            }

            /*now we check the string to:
            *1-see if 2 same characters in a single pair
            *if so then add x between them
            */
            for (int count1 = 0; ((count1 < tmp_str.Length) && ((count1 + 1) < tmp_str.Length)); count1 += 2)
            {

                if (tmp_str[count1] == tmp_str[count1 + 1])
                {
                    tmp_str.Insert(count1 + 1, "x");
                }

            }

            //if the size of the message is odd .. then add x at the end.
            if ((tmp_str.Length % 2) == 1)
            {
                tmp_str.Append("x");
            }

            //convert the whole message into capital letters .. because  the matrix is capital letters
            for (int count1 = 0; count1 < tmp_str.Length; count1++)
            {

                if (tmp_str[count1] >= 'a' && tmp_str[count1] <= 'z') //if the letter is small letter
                {
                    tmp_str[count1] -= (char)((int)'a' - (int)'A'); //convert it into capital letter
                }

            }

            String key = textboxkey.Text.ToString();
            StringBuilder tmp_key = new StringBuilder(key);

            //change every 'j' character in the keyword into 'i' character(because they are stored in the same element
            for (int count1 = 0; count1 < tmp_key.Length; count1 += 1)
            {

                if (tmp_key[count1] == 'j')
                {
                    tmp_key[count1] = 'i';
                }

                if (tmp_key[count1] == 'J')
                {
                    tmp_key[count1] = 'I';
                }

            }

            //remove all the repeated characters from the keyword
            for (int count1 = 0; count1 < tmp_key.Length; count1++)
            {

                //loop for the previous characters to see if the current character existed before
                for (int count2 = 0; count2 < count1; count2++)
                {

                    if (tmp_key[count1] == tmp_key[count2]) //if a character existed before
                    {
                        tmp_key = tmp_key.Remove(count1, 1); //erase this repeated element
                        count1--;
                        break; // exit the loop
                    }

                }

            }

            //convert the whole keyword into capital letters ,because  the matrix is capital letters so it's
            //saved as capital letters
            for (int count1 = 0; count1 < tmp_key.Length; count1++)
            {

                if (tmp_key[count1] >= 'a' && tmp_key[count1] <= 'z') //if the letter is small letter
                {
                    tmp_key[count1] -= (char)((int)'a' - (int)'A'); //convert it into capital letter
                }

            }

            int keyword_stored_flag = 0; // flag that indicates if the entire keyword has been stored in
            //the matrix or not
            int exists_in_keyord = 0; //a flag  that indicates if the alphabet exists in the keyword
            //(see below code)

            char[,] matrix = new char[5, 5];

            //this loop stores the keyword and the rest of the alphabets in the matrix
            for (int row_count = 0, alphabet_counter = 0; row_count < 5; row_count++)
            {

                for (int col_count = 0; col_count < 5; col_count++)
                {

                    //store the keyword character in the matrix then store the rest of the alphabets
                    if ((((row_count * 5) + col_count) < tmp_key.Length) && (keyword_stored_flag == 0))
                    {
                        matrix[row_count, col_count] = tmp_key[(row_count * 5) + col_count];
                    }
                    else //if the keyword is stored so that we have to store the rest of the alphabets
                    {
                        keyword_stored_flag = 1;
                        exists_in_keyord = 0; //clear the flag every rime you repeat the loop

                        //check if the current alphabet exists in the keyword
                        for (int count1 = 0; count1 < tmp_key.Length; count1++)
                        {

                            if ('A' + alphabet_counter == tmp_key[count1]) //if the current alphabet exists in the keyword
                            {
                                exists_in_keyord = 1;
                                break;
                            }

                        }

                        // if it the current alphabet doesn't exist in the alphabet is not j letter
                        if ((exists_in_keyord == 0) && (('A' + alphabet_counter) != 'J'))
                        {
                            matrix[row_count, col_count] = (char)((int)'A' + alphabet_counter);//store it in the matrix
                        }
                        else
                        {
                            col_count--;
                        }

                        alphabet_counter++;
                    }

                }

            }


            //perform the cipher
            int letter1_row = 0, letter1_col = 0, letter2_row = 0, letter2_col = 0;

            for (int m_count = 0; m_count < tmp_str.Length; m_count += 2)
            {

                get_index(matrix, tmp_str[m_count], ref letter1_row, ref letter1_col);
                get_index(matrix, tmp_str[m_count + 1], ref letter2_row, ref letter2_col);

                if (letter1_row == letter2_row)
                {
                    tmp_str[m_count] = matrix[letter1_row, (letter1_col + 1) % 5];
                    tmp_str[m_count + 1] = matrix[letter2_row, (letter2_col + 1) % 5];
                }
                else if (letter1_col == letter2_col)
                {
                    tmp_str[m_count] = matrix[(letter1_row + 1) % 5, letter1_col];
                    tmp_str[m_count + 1] = matrix[(letter2_row + 1) % 5, letter2_col];
                }
                else
                {
                    tmp_str[m_count] = matrix[letter1_row, letter2_col];
                    tmp_str[m_count + 1] = matrix[letter2_row, letter1_col];
                }

            }

            for (int count = 0; space_indexes[count] != -1; count++)
            {
                tmp_str.Insert(space_indexes[count] + count, " ");
            }

            str = tmp_str.ToString();

            return str;


        }

        void get_index(char[,] matrix, char chr, ref int row, ref int col)
        {
            try
            {
                //keep looping in  the matrix until you find the character and then return its coordinates
                for (int row_count = 0, char_match_flag = 0; char_match_flag == 0; row_count++)
                {

                    for (int col_count = 0; col_count < 5; col_count++)
                    {

                        if (matrix[row_count, col_count] == chr)
                        {
                            char_match_flag = 1;
                            col = col_count;
                            row = row_count;
                            break;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String str = textboxencrypted.Text.ToString();



            Invoke(new Action(() => textboxdecrypted.Clear()));
            Invoke(new Action(() => textboxdecrypted.AppendText(PlayFair_decrypt(str))));

            if (textboxkey.Text == "") return;


        }

        String PlayFair_decrypt(String str)
        {
            //convert the whole message into capital letters .. because  the matrix is capital letters
            StringBuilder tmp_str = new StringBuilder(str.ToUpper());

            //we'll need to remove all the spaces between the word so we need to store their indexes
            //inorder to place them again after the encryption is done
            int[] space_indexes = new int[20];
            int space_count = 0;

            for (int count1 = 0; count1 < tmp_str.Length; count1 += 1)
            {

                if (tmp_str[count1] == ' ')
                {
                    tmp_str = tmp_str.Remove(count1, 1);
                    space_indexes[space_count] = count1;
                    space_count++;
                }

            }

            space_indexes[space_count] = -1; // assign the end of the spaces by putting the last element 
            //with -1

            String key = textboxkey.Text.ToString();

            //convert the whole keyword into capital letters ,because  the matrix is capital letters so it's
            //saved as capital letters
            StringBuilder tmp_key = new StringBuilder(key.ToUpper());

            //change every 'j' character in the keyword into 'i' character(because they are stored in the same element
            for (int count1 = 0; count1 < tmp_key.Length; count1 += 1)
            {

                if (tmp_key[count1] == 'J')
                {
                    tmp_key[count1] = 'I';
                }

            }

            //remove all the repeated characters from the keyword
            for (int count1 = 0; count1 < tmp_key.Length; count1++)
            {

                //loop for the previous characters to see if the current character existed before
                for (int count2 = 0; count2 < count1; count2++)
                {

                    if (tmp_key[count1] == tmp_key[count2]) //if a character existed before
                    {
                        tmp_key = tmp_key.Remove(count1, 1); //erase this repeated element
                        count1--;
                        break; // exit the loop
                    }

                }

            }

            int keyword_stored_flag = 0; // flag that indicates if the entire keyword has been stored in
            //the matrix or not
            int exists_in_keyord = 0; //a flag  that indicates if the alphabet exists in the keyword
            //(see below code)

            char[,] matrix = new char[5, 5];

            //this loop stores the keyword and the rest of the alphabets in the matrix
            for (int row_count = 0, alphabet_counter = 0; row_count < 5; row_count++)
            {

                for (int col_count = 0; col_count < 5; col_count++)
                {

                    //store the keyword character in the matrix then store the rest of the alphabets
                    if ((((row_count * 5) + col_count) < tmp_key.Length) && (keyword_stored_flag == 0))
                    {
                        matrix[row_count, col_count] = tmp_key[(row_count * 5) + col_count];
                    }
                    else //if the keyword is stored so that we have to store the rest of the alphabets
                    {
                        keyword_stored_flag = 1;
                        exists_in_keyord = 0; //clear the flag every rime you repeat the loop

                        //check if the current alphabet exists in the keyword
                        for (int count1 = 0; count1 < tmp_key.Length; count1++)
                        {

                            if ('A' + alphabet_counter == tmp_key[count1]) //if the current alphabet exists in the keyword
                            {
                                exists_in_keyord = 1;
                                break;
                            }

                        }

                        // if it the current alphabet doesn't exist in the alphabet is not j letter
                        if ((exists_in_keyord == 0) && (('A' + alphabet_counter) != 'J'))
                        {
                            matrix[row_count, col_count] = (char)((int)'A' + alphabet_counter);//store it in the matrix
                        }
                        else
                        {
                            col_count--;
                        }

                        alphabet_counter++;
                    }

                }

            }

            //perform the decryption
            int letter1_row = 0, letter1_col = 0, letter2_row = 0, letter2_col = 0;

            for (int m_count = 0; m_count < tmp_str.Length; m_count += 2)
            {

                get_index(matrix, tmp_str[m_count], ref letter1_row, ref letter1_col);
                get_index(matrix, tmp_str[m_count + 1], ref letter2_row, ref letter2_col);

                if (letter1_row == letter2_row)
                {
                    tmp_str[m_count] = matrix[letter1_row, (letter1_col + 4) % 5];
                    tmp_str[m_count + 1] = matrix[letter2_row, (letter2_col + 4) % 5];
                }
                else if (letter1_col == letter2_col)
                {
                    tmp_str[m_count] = matrix[(letter1_row + 4) % 5, letter1_col];
                    tmp_str[m_count + 1] = matrix[(letter2_row + 4) % 5, letter2_col];
                }
                else
                {
                    tmp_str[m_count] = matrix[letter1_row, letter2_col];
                    tmp_str[m_count + 1] = matrix[letter2_row, letter1_col];
                }


            }

            for (int i = tmp_str.Length - 1; i >= 0; i--)
            {
                if (tmp_str[i] == 'X')
                {

                    if (i > 0)
                    {
                        if (i == (tmp_str.Length - 1)) //if it's the X on the last string
                        {
                            tmp_str.Remove(i, 1); // remove th X
                        }
                        else if (tmp_str[i - 1] == tmp_str[i + 1]) //if it's the X that separates the 2 same chars
                        {
                            tmp_str.Remove(i, 1); // remove the X
                        }
                    }

                }
            }

            //retern the space back to the result
            for (int count = 0; space_indexes[count] != -1; count++)
            {
                tmp_str.Insert(space_indexes[count] + count, " "); // I used this type of indexing because every time I add a space
                //the wohle order of index in the string is incremented
                // so every time I add a space back I need to increment the address
                //of this space by the number of spaces added before it(or in
                //other words the number of indexes the were added to the string
            }

            str = tmp_str.ToString();
            return str;
        }

        private void Textboxmessage_Click(object sender, EventArgs e)
        {

        }

        private void Textboxdecrypted_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.PnlContainer.Controls.ContainsKey("UserControlAlgorithms"))
            {
                UserControlAlgorithms ucal = new UserControlAlgorithms();
                ucal.Dock = DockStyle.Fill;
                FrmMain.Instance.PnlContainer.Controls.Add(ucal);
            }

            FrmMain.Instance.PnlContainer.Controls["UserControlAlgorithms"].BringToFront();
        }
    }
}
