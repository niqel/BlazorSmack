namespace BlazorSmackGame.Models
{
    public class SquareModel
    {
        private bool isShow;

        public int Id { get; set; }
        public string Style { get; set; }
        public bool IsShow 
        { 
            get => isShow; 
            set 
            {
                isShow = value;
                if(isShow)
                {
                    Style = "mole";
                }
                else
                {
                    Style = "";
                }
            }
    }
}