using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Tourist_Assistant.ObjectRepository
{
    public static class Descriptors
    {
        public static class OpenWebPage
        {
            static string _reference = "o1OyEP-s8UWNQQHnvTl1FA/X-EilYhCAUegazex_uHJlQ";
            public static _Implementation._OpenWebPage.__Confirmation Confirmation { get; private set; } = new _Implementation._OpenWebPage.__Confirmation();
            public static _Implementation._OpenWebPage.__Download Download { get; private set; } = new _Implementation._OpenWebPage.__Download();
            public static _Implementation._OpenWebPage.__HostingData HostingData { get; private set; } = new _Implementation._OpenWebPage.__HostingData();
            public static _Implementation._OpenWebPage.__Personalinformation Personalinformation { get; private set; } = new _Implementation._OpenWebPage.__Personalinformation();
            public static _Implementation._OpenWebPage.__Questions Questions { get; private set; } = new _Implementation._OpenWebPage.__Questions();
            public static _Implementation._OpenWebPage.__Terms Terms { get; private set; } = new _Implementation._OpenWebPage.__Terms();
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

    namespace _OpenWebPage._Confirmation
    {
        public class __Download : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Download(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/4otFUften0aPnNbzE4qRtg", DisplayName = "Download", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __Confirmation : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Confirmation()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/7OSi1eQUNUWBCB0mgk3mgg", DisplayName = "Confirmation", Screen = this};
                Download = new _Implementation._OpenWebPage._Confirmation.__Download(this, null);
            }

            public _Implementation._OpenWebPage._Confirmation.__Download Download { get; private set; }
        }
    }

    namespace _OpenWebPage._Download
    {
        public class __Path : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Path(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/-mrL2mmmzkO7S07WJS4Rtg", DisplayName = "Path", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Download
    {
        public class __Save : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Save(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/prEtxYWwJ0-z5xG-fTNGMQ", DisplayName = "Save", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __Download : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Download()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/wZ8e7PHWZEOu_yL0z_F0mg", DisplayName = "Download", Screen = this};
                Path = new _Implementation._OpenWebPage._Download.__Path(this, null);
                Save = new _Implementation._OpenWebPage._Download.__Save(this, null);
            }

            public _Implementation._OpenWebPage._Download.__Path Path { get; private set; }

            public _Implementation._OpenWebPage._Download.__Save Save { get; private set; }
        }
    }

    namespace _OpenWebPage._HostingData
    {
        public class __Address : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Address(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/T42SMtbo7EO_VK_wagukZQ", DisplayName = "Address", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._HostingData
    {
        public class __City : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __City(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/MXniKQr08U6SQeyZXZYNeA", DisplayName = "City", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._HostingData
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/EZFbZziUGUq2yrTJCpdvug", DisplayName = "Continue", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._HostingData
    {
        public class __PhoneNumber : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __PhoneNumber(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/tzS40vBHqEmoZeNKYVAJDg", DisplayName = "PhoneNumber", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __HostingData : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __HostingData()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/CDKPItw8SkOX7xiUobn1yg", DisplayName = "HostingData", Screen = this};
                Address = new _Implementation._OpenWebPage._HostingData.__Address(this, null);
                City = new _Implementation._OpenWebPage._HostingData.__City(this, null);
                Continue = new _Implementation._OpenWebPage._HostingData.__Continue(this, null);
                PhoneNumber = new _Implementation._OpenWebPage._HostingData.__PhoneNumber(this, null);
            }

            public _Implementation._OpenWebPage._HostingData.__Address Address { get; private set; }

            public _Implementation._OpenWebPage._HostingData.__City City { get; private set; }

            public _Implementation._OpenWebPage._HostingData.__Continue Continue { get; private set; }

            public _Implementation._OpenWebPage._HostingData.__PhoneNumber PhoneNumber { get; private set; }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __Cedula : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Cedula(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/qBaghpGSuUOtN9iD8WMyPQ", DisplayName = "Cedula", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __ConfirmEmail : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ConfirmEmail(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/Z7A0KkTtzU2xtEXlGpzYnw", DisplayName = "ConfirmEmail", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/fpSupDKp3kGbUJbQ-7PzeQ", DisplayName = "Continue", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __DateOfBirth : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __DateOfBirth(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/l2gYpnmz3k2x3LcCQ9FRCw", DisplayName = "DateOfBirth", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __Email : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/_k6NJtmGvUu-UCQ7wJYnWA", DisplayName = "Email", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __FirstName1 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __FirstName1(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/2RKJgJdSHE-7aF9gJaz8PQ", DisplayName = "FirstName1", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __FirstName2 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __FirstName2(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/E0urCgze0E60sHBeB6_RCg", DisplayName = "FirstName2", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __IdNumber : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __IdNumber(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/P9B65b4vVkirVl5R-sAI3Q", DisplayName = "IdNumber", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __Nationality : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Nationality(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/7pOlPuCWwUScnPw2eeCSbA", DisplayName = "Nationality", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __Pasaporte : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Pasaporte(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/SYh2MxqvPEa4aXOrE6PKXg", DisplayName = "Pasaporte", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __Purpose : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Purpose(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/MQ3OcyYrJU2UR0ORWcztAQ", DisplayName = "Purpose", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __SurName1 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __SurName1(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/_xItj-t-o0CX-Xsr-FIOPA", DisplayName = "SurName1", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Personalinformation
    {
        public class __SurName2 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __SurName2(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/mQZP2JfqFkOlW8J0Fa8N5w", DisplayName = "SurName2", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __Personalinformation : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Personalinformation()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/094CeSVphkqyPDpdSzFoiw", DisplayName = "Personalinformation", Screen = this};
                Cedula = new _Implementation._OpenWebPage._Personalinformation.__Cedula(this, null);
                ConfirmEmail = new _Implementation._OpenWebPage._Personalinformation.__ConfirmEmail(this, null);
                Continue = new _Implementation._OpenWebPage._Personalinformation.__Continue(this, null);
                DateOfBirth = new _Implementation._OpenWebPage._Personalinformation.__DateOfBirth(this, null);
                Email = new _Implementation._OpenWebPage._Personalinformation.__Email(this, null);
                FirstName1 = new _Implementation._OpenWebPage._Personalinformation.__FirstName1(this, null);
                FirstName2 = new _Implementation._OpenWebPage._Personalinformation.__FirstName2(this, null);
                IdNumber = new _Implementation._OpenWebPage._Personalinformation.__IdNumber(this, null);
                Nationality = new _Implementation._OpenWebPage._Personalinformation.__Nationality(this, null);
                Pasaporte = new _Implementation._OpenWebPage._Personalinformation.__Pasaporte(this, null);
                Purpose = new _Implementation._OpenWebPage._Personalinformation.__Purpose(this, null);
                SurName1 = new _Implementation._OpenWebPage._Personalinformation.__SurName1(this, null);
                SurName2 = new _Implementation._OpenWebPage._Personalinformation.__SurName2(this, null);
            }

            public _Implementation._OpenWebPage._Personalinformation.__Cedula Cedula { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__ConfirmEmail ConfirmEmail { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__Continue Continue { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__DateOfBirth DateOfBirth { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__Email Email { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__FirstName1 FirstName1 { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__FirstName2 FirstName2 { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__IdNumber IdNumber { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__Nationality Nationality { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__Pasaporte Pasaporte { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__Purpose Purpose { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__SurName1 SurName1 { get; private set; }

            public _Implementation._OpenWebPage._Personalinformation.__SurName2 SurName2 { get; private set; }
        }
    }

    namespace _OpenWebPage._Questions
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/53V75nBh5Em_DSVUFX_BAw", DisplayName = "Continue", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Questions
    {
        public class __No : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __No(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/qg2ITZ6FJEOuLNn0nv8mEg", DisplayName = "No", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __Questions : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Questions()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/7ieOT5xOFEWdOoMCZrjDng", DisplayName = "Questions", Screen = this};
                Continue = new _Implementation._OpenWebPage._Questions.__Continue(this, null);
                No = new _Implementation._OpenWebPage._Questions.__No(this, null);
            }

            public _Implementation._OpenWebPage._Questions.__Continue Continue { get; private set; }

            public _Implementation._OpenWebPage._Questions.__No No { get; private set; }
        }
    }

    namespace _OpenWebPage._Terms
    {
        public class __Accept : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Accept(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/74BuG94i5UK7_WMrZ3xMgw", DisplayName = "Accept", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Terms
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/WcFUUxudC0ujD_rP0vFL6g", DisplayName = "Continue", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage
    {
        public class __Terms : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Terms()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/bN9k7lC6_0mY52QEXhRkfw", DisplayName = "Terms", Screen = this};
                Accept = new _Implementation._OpenWebPage._Terms.__Accept(this, null);
                Continue = new _Implementation._OpenWebPage._Terms.__Continue(this, null);
            }

            public _Implementation._OpenWebPage._Terms.__Accept Accept { get; private set; }

            public _Implementation._OpenWebPage._Terms.__Continue Continue { get; private set; }
        }
    }

    namespace _OpenWebPage._Travelinformation
    {
        public class __CheckError : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __CheckError(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/epUUKLbcFUKUQI-qvSVyLA", DisplayName = "CheckError", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Travelinformation
    {
        public class __ChooseFirst : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ChooseFirst(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/ocx4VgrY_0yEv02_QSIWFw", DisplayName = "ChooseFirst", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/vQfwPDaTMkSIax__w1q1Cw", DisplayName = "Continue", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Travelinformation
    {
        public class __Country : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Country(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/tSJySl7500OHuUYA349CPg", DisplayName = "Country", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Travelinformation
    {
        public class __FlightNum : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __FlightNum(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/v7nrrkKT2EOi0JBTYYcYhw", DisplayName = "FlightNum", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _OpenWebPage._Travelinformation
    {
        public class __ImmigrationCheckpoint : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ImmigrationCheckpoint(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/hje_x0tPX0yEFcRe_XAjZw", DisplayName = "ImmigrationCheckpoint", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
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

    namespace _OpenWebPage._Travelinformation
    {
        public class __TravelDate : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TravelDate(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "o1OyEP-s8UWNQQHnvTl1FA/5wXwHi77IEer6g7QpjnkIA", DisplayName = "TravelDate", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
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
                CheckError = new _Implementation._OpenWebPage._Travelinformation.__CheckError(this, null);
                ChooseFirst = new _Implementation._OpenWebPage._Travelinformation.__ChooseFirst(this, null);
                CommercialFlight = new _Implementation._OpenWebPage._Travelinformation.__CommercialFlight(this, null);
                Continue = new _Implementation._OpenWebPage._Travelinformation.__Continue(this, null);
                Country = new _Implementation._OpenWebPage._Travelinformation.__Country(this, null);
                FlightNum = new _Implementation._OpenWebPage._Travelinformation.__FlightNum(this, null);
                ImmigrationCheckpoint = new _Implementation._OpenWebPage._Travelinformation.__ImmigrationCheckpoint(this, null);
                PrivateFlight = new _Implementation._OpenWebPage._Travelinformation.__PrivateFlight(this, null);
                TravelDate = new _Implementation._OpenWebPage._Travelinformation.__TravelDate(this, null);
            }

            public _Implementation._OpenWebPage._Travelinformation.__CheckError CheckError { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__ChooseFirst ChooseFirst { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__CommercialFlight CommercialFlight { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__Continue Continue { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__Country Country { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__FlightNum FlightNum { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__ImmigrationCheckpoint ImmigrationCheckpoint { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__PrivateFlight PrivateFlight { get; private set; }

            public _Implementation._OpenWebPage._Travelinformation.__TravelDate TravelDate { get; private set; }
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