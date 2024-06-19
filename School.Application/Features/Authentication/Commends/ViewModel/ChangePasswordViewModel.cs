using System.ComponentModel.DataAnnotations;

namespace School.Application.Features.Authentication.Commends.ViewModel
{
    public class ChangePasswordViewModel
    {
        public string OldPassword { get; private set; }
        public string NewPassword { get; private set; }
        [Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; private set; }

        public ChangePasswordViewModel(string newPassword, string oldPassword, string confirmPassword)
        {
            NewPassword = newPassword;
            OldPassword = oldPassword;
            ConfirmPassword = confirmPassword;
        }
    }
}
