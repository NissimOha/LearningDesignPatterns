namespace Nissim.On.Composite
{
    /// <summary>
    /// The 'Component' Tree node
    /// </summary>
    interface IWorker
    {
        int Id { get; set; }
        string Name { get; set; }
        //Show Hierarchy From the Worder down.
        void ShowHierarchy();
    }
}
