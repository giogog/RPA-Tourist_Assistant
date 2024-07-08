using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Tourist_Assistant.ObjectRepository
{
    public static class Descriptors
    {
        public static class OpenWebPage
        {
            static string _reference = "o1OyEP-s8UWNQQHnvTl1FA/X-EilYhCAUegazex_uHJlQ";
            public static _Implementation._OpenWebPage.__Travelinformation Travelinformation { get; private set; } = new _Implementation._OpenWebPage.__Travelinformation();
            public static _Implementation._OpenWebPage.__TypeOfJourney TypeOfJourney { get; private set; } = new _Implementation._OpenWebPage.__TypeOfJourney();
            public static _Implementation._OpenWebPage.__WebPage WebPage { get; private set; } = new _Implementation._OpenWebPage.__WebPage();
        }
    }
}

namespace Tourist_Assistant._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _OpenWebPage._Travelinformation
    {
        public class __CommercialFlight : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __CommercialFlight(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/bXqRG5N4BEeAY7JU1xbjGA", DisplayName = "CommercialFlight", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Travelinformation
    {
        public class __PrivateFlight : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __PrivateFlight(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/lnV5QZE0JU6pkUbgCRCkgA", DisplayName = "PrivateFlight", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __Travelinformation : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Travelinformation()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/wb3gXic5-UCuJypdbZjb2g", DisplayName = "Travelinformation", Screen = this};
                CommercialFlight = new _Implementation._OpenWebPage._Travelinformation.__CommercialFlight(this, null);
                PrivateFlight = new _Implementation._OpenWebPage._Travelinformation.__PrivateFlight(this, null);
            }

            public _Implementation._OpenWebPage._Travelinformation.__CommercialFlight CommercialFlight { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__PrivateFlight PrivateFlight { get; private set; }
        }
    }

    namespace _OpenWebPage._TypeOfJourney
    {
        public class __Air : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Air(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/Abo8GVzPu0qRkVDlJPY47Q", DisplayName = "Air", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._TypeOfJourney
    {
        public class __Continue : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Continue(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/EgNEv0plR0WDTctH8o997w", DisplayName = "Continue", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._TypeOfJourney
    {
        public class __fromColombia : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __fromColombia(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/u6JLBQWMcU6G8z-5wV1h7g", DisplayName = "fromColombia", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._TypeOfJourney
    {
        public class __toColombia : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __toColombia(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/R2ty5zDJK0q0lcSIx9mE9A", DisplayName = "toColombia", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __TypeOfJourney : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __TypeOfJourney()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/ztObGy-YZEWOoUcUmccnxg", DisplayName = "TypeOfJourney", Screen = this};
                Air = new _Implementation._OpenWebPage._TypeOfJourney.__Air(this, null);
                Continue = new _Implementation._OpenWebPage._TypeOfJourney.__Continue(this, null);
                fromColombia = new _Implementation._OpenWebPage._TypeOfJourney.__fromColombia(this, null);
                toColombia = new _Implementation._OpenWebPage._TypeOfJourney.__toColombia(this, null);
            }

            public _Implementation._OpenWebPage._TypeOfJourney.__Air Air { get; private set; }

            public _Implementation._OpenWebPage._TypeOfJourney.__Continue Continue { get; private set; }

            public _Implementation._OpenWebPage._TypeOfJourney.__fromColombia fromColombia { get; private set; }

            public _Implementation._OpenWebPage._TypeOfJourney.__toColombia toColombia { get; private set; }
        }
    }

    namespace _OpenWebPage._WebPage
    {
        public class __Do_Checkmig : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Do_Checkmig(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/aTZKfDHCGUWoDaX651ALkA", DisplayName = "Do Checkmig", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __WebPage : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __WebPage()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/xNWYDKvOe0qGKlEKrkVcVA", DisplayName = "WebPage", Screen = this};
                Do_Checkmig = new _Implementation._OpenWebPage._WebPage.__Do_Checkmig(this, null);
            }

            public _Implementation._OpenWebPage._WebPage.__Do_Checkmig Do_Checkmig { get; private set; }
        }
    }
}