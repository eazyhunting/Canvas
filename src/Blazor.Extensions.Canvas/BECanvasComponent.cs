using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazor.Extensions
{
    public class BECanvasComponent : ComponentBase
    {
        [Parameter]
        public long Height { get; set; }

        [Parameter]
        public long Width { get; set; }

        [Parameter]
        public bool ContextMenuPreventDefault { get; set; } = false;

        [Parameter]
        public bool ContextMenuStopPropagation { get; set; } = false;

        [Parameter]
        public EventCallback<MouseEventArgs> ContextMenu { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> Click { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> DoubleClick { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> MouseDown { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> MouseUp { get; set; }

        [Parameter]
        public EventCallback<WheelEventArgs> MouseWheel { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> MouseMove { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> MouseOver { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> MouseOut { get; set; }

        [Parameter]
        public EventCallback<FocusEventArgs> Focus { get; set; }

        [Parameter]
        public EventCallback<FocusEventArgs> Blur { get; set; }

        [Parameter]
        public EventCallback<KeyboardEventArgs> KeyDown { get; set; }

        [Parameter]
        public EventCallback<KeyboardEventArgs> KeyUp { get; set; }

        [Parameter]
        public EventCallback<KeyboardEventArgs> KeyPress { get; set; }

        [Parameter]
        public EventCallback<ProgressEventArgs> Load { get; set; }

        [Parameter]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        protected ElementReference _canvasRef;

        public ElementReference CanvasReference => this._canvasRef;

        [Inject]
        internal IJSRuntime JSRuntime { get; set; }
    }
}
