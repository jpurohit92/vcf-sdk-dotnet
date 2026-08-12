# Vcenter.ViJson.OpenApi.Model.VsanPerfMasterInformation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SecSinceLastStatsWrite** | **long** | Seconds since last time we successfully wrote stats to the DB.  If larger than 2 intervals, we definitely have an issue. If not set, means there was never a successful stats write on this master.  | [optional] 
**SecSinceLastStatsCollect** | **long** | Seconds since last time we successfully collected stats from the cluster.  If larger than 2 intervals, we definitely have an issue. If not set, means there was never a successful stats collection on this master.  | [optional] 
**StatsIntervalSec** | **long** | Configured stats collection interval, in seconds.  | 
**CollectionFailureHostUuids** | **List&lt;string&gt;** | vSAN UUIDs of hosts that we failed to collect stats for in last successful stats collection.  | [optional] 
**RenamedStatsDirectories** | **List&lt;string&gt;** | Names of directories which are likely renamed previously used vSAN stats DB objects.  Renames can occur if two stats DB objects (hence with the same name) were to exist in the same cluster, e.g. after a cluster merge.  | [optional] 
**StatsDirectoryPercentFree** | **long** | Percentage of free space in the vSAN stats DB object.  The object is of fixed size. This number represents the logical free space, i.e., it is possible that the overall datastore or underlying physical disks are out of space without this metric showing a low free percentage.  | [optional] 
**VerboseMode** | **bool** | Verbose mode By default, performance service run with verbose mode disabled.  It only collects the statistics in the &#39;alway collect&#39; categories. Users can configure performance via API or vSphere Web Client to enable/disable verbose mode. In verbose mode, performance service collects extra stats for support cases. The verbose mode is a vSAN cluster level configuration item, which is pushed to each host in vSAN clusters.  | [optional] 
**VerboseModeLastUpdate** | **DateTime** | Verbose mode last update time.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

