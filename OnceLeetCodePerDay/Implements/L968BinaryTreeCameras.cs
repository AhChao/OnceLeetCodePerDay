namespace OnceLeetCodePerDay.Implements;

public class L968BinaryTreeCameras
{
    private int _cameraCount;
    private const int NoChild = -2;
    private const int NoCamera = -1;
    private const int NoNeedToMonitor = 0;
    private const int WithCamera = 1;

    public int MinCameraCover(TreeNode root)
    {
        _cameraCount = 0;
        var isRootMonitored = DFSIsNodeMonitored(root);
        return isRootMonitored == NoCamera ? _cameraCount + 1 : _cameraCount;
    }

    private int DFSIsNodeMonitored(TreeNode root)
    {
        if(root == null)
        {
            return NoChild;
        }

        var isLeftChildMonitored = DFSIsNodeMonitored(root.left);
        var isRightChildMonitored = DFSIsNodeMonitored(root.right);
        if(isLeftChildMonitored == NoCamera || isRightChildMonitored == NoCamera)
        {
            _cameraCount++;
            return WithCamera;
        }
        else if(isRightChildMonitored == WithCamera || isLeftChildMonitored == WithCamera)
        {
            return NoNeedToMonitor;
        }
        else
        {
            return NoCamera;
        }
    }
}