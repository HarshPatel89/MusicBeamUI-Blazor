using Microsoft.JSInterop;

namespace MusicBeam.Helpers
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime _JSRuntime, string message)
        {
            await _JSRuntime.InvokeVoidAsync("showToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime _JSRuntime, string message)
        {
            await _JSRuntime.InvokeVoidAsync("showToastr", "error", message);
        }

        public static async Task SweetSuccess(this IJSRuntime _JSRuntime, string message)
        {
            await _JSRuntime.InvokeVoidAsync("showSweetAlert", "success", message);
        }
        public static async Task SweetError(this IJSRuntime _JSRuntime, string message)
        {
            await _JSRuntime.InvokeVoidAsync("showSweetAlert", "error", message);
        }
    }
}
