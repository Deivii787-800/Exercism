public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string newYorkNumber = phoneNumber.Split("-")[0];
        string fakeNumber = phoneNumber.Split("-")[1];
        string lastNumbers = phoneNumber.Split("-")[2];
        return (isNewYork: newYorkNumber == "212", IsFake: fakeNumber == "555", LocalNumber: lastNumbers);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
