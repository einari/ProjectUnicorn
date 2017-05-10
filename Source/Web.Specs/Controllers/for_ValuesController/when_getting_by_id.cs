using Web.Controllers;
using Machine.Specifications;

namespace Web.Specs.Controllers.for_ValuesController
{
    public class when_getting_by_id
    {
        static ValuesController controller;
        static string result;

        Establish context = () => controller = new ValuesController();

        Because of = () => result = controller.Get(1);

        It should_return_value_as_string = () => result.ShouldEqual("value");

    }
}