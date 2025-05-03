using System.ComponentModel.DataAnnotations;

namespace HR_helper.Models
{
    public class SkillsSet
    {
        public class SkillsForAnalyse
        {
            [Required(ErrorMessage = "Поле обязательно")]
            [MinLength(1, ErrorMessage = "Нужен как минимум 1 навык")]
            public string[] Skills { get; set; }
        }
    }
}
