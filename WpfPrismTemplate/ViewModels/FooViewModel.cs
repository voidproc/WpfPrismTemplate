using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrismTemplate.ViewModels
{
    public class FooViewModel : BindableBase
    {
        public ReactivePropertySlim<string> Head { get; }

        public FooViewModel()
        {
            Head = new ReactivePropertySlim<string>("FooView");
        }
    }
}
