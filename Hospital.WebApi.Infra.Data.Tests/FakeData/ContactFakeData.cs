using Hospital.WebApi.Domain.Models;
using System.Collections.Generic;

namespace Hospital.WebApi.Infra.Data.Tests.FakeData
{
    public static class ContactFakeData
    {
        public static List<ContactModel> Get() =>
            new List<ContactModel>()
            {
                new ContactModel(cellPhone: "(11)90000-1657", email: "teste@gmail.com"),
                new ContactModel(cellPhone: "(12)91658-0000", email: "testeum@gmail.com"),
                new ContactModel(cellPhone: "(13)90016-0000", email: "testedois@gmail.com"),
                new ContactModel(cellPhone: "(14)90000-1500", email: "testetres@gmail.com"),
                new ContactModel(cellPhone: "(15)90000-0100", email: "testequatro@gmail.com"),
                new ContactModel(cellPhone: "(16)90265-0010", email: "testecinco@gmail.com"),
                new ContactModel(cellPhone: "(17)90014-0000", email: "testeseis@gmail.com"),
                new ContactModel(cellPhone: "(18)90167-0014", email: "testesete@gmail.com"),
                new ContactModel(cellPhone: "(19)91957-0197", email: "testeoito@gmail.com"),
                new ContactModel(cellPhone: "(20)90019-0220", email: "testenove@gmail.com")
            };       
    }
}
