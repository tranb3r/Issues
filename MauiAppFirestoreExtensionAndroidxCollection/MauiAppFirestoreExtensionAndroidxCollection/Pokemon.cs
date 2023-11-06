using Plugin.Firebase.Firestore;

namespace MauiAppFirestoreExtensionAndroidxCollection
{
    internal class Pokemon : IFirestoreObject
    {
        [FirestoreDocumentId]
        public string Id { get; private set; }

        [FirestoreProperty("name")]
        public string Name { get; private set; }
    }
}
