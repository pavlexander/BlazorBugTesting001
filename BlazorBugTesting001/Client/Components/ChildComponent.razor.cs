using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBugTesting001.Client.Components
{
    public partial class ChildComponent
    {
        private Random r = new Random();

        [Parameter]
        public int Year { get; set; }

        [Parameter]
        public EventCallback<int> YearChanged { get; set; }

        private async Task UpdateYearFromChild()
        {
            await YearChanged.InvokeAsync(r.Next(1950, 2021));
        }
    }
}
