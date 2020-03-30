namespace Flinter
{
    /// <summary>
    /// This class represents a person profile,
    /// for instance for a dating website
    /// </summary>
    public class Profile
    {
        #region Instance fields
        public enum Gender{Male, Female};
        public enum EyeColor{Green, Blue, Brown};
        public enum HairColor{Black, Blond, Brown, White};
        public enum HeightCategory{VeryShort, Short, MediumHeight, Tall};
        #endregion
        private Gender _gender;
        private EyeColor _eyeColor;
        private HairColor _hairColor;
        private HeightCategory _heightCategory;

        

        #region Constructor
        public Profile(Gender gender, EyeColor eyeColor, HairColor hairColor, HeightCategory heightCategory)
        {
            _gender = gender;
            _eyeColor = eyeColor;
            _hairColor = hairColor;
            _heightCategory = heightCategory;
        }
        #endregion

        #region Properties
        public string Description
        {
            get
            {
                return $"You got a {_gender} with {_eyeColor} eyes and {_hairColor} hair, who is {_heightCategory}";
            }
        }

        // public string GenderDescription
        // {
        //     get { return _gender ? "man" : "woman"; }
        // }

        // public string HeightDescription
        // {
        //     get
        //     {
        //         switch (_heightCategory)
        //         {
        //             case 0:
        //                 return "Very short";
        //             case 1:
        //                 return "Short";
        //             case 2:
        //                 return "Medium height";
        //             case 3:
        //                 return "Tall";
        //             case 4:
        //                 return "Very tall";
        //             default:
        //                 return "Unknown height";
        //         }
        //     }
            
        // } 
        #endregion
        // public enum gender1
        //     {
        //             Male =0, Female=1
        //     }
        // public enum eyeColor1
        // {
        //     Blue =1, Brown=2, Green=3
        // }
        // public enum hairColor1
        //     {
        //         Black=1, Blond=2, Brown=3, White=4
        //     }
        // public enum heightCategory1
        // {
        //     VeryShort=1, Short=2, MediumHeight=3, Tall=4
        // }
    }
}