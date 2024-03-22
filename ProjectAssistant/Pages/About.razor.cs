using Microsoft.AspNetCore.Components;

namespace ProjectAssistant.Pages
{
    partial class About : ComponentBase
    {
        private string title = "About";
        private string Title { 
            get { return title; }
            set { title = value; }
        }
    }
}
