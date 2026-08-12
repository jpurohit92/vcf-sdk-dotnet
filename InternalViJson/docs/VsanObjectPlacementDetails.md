# Vcenter.ViJson.OpenApi.Model.VsanObjectPlacementDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Object UUID  | 
**Type** | **string** | Object type identification.  For example, it can be one of \&quot;vmswap\&quot;, \&quot;vdisk\&quot;, \&quot;namespace\&quot;, \&quot;vmem\&quot;, \&quot;attachedCnsVolBlock\&quot;, \&quot;detachedCnsVolBlock\&quot;, or else.  | 
**Name** | **string** | Object display name.  | [optional] 
**IsRemote** | **bool** | Flag if the object storage is configured remotely.  If True, the object will be reported under the Remote Object view If False, the object will be reported under the Local Object view, neither remoteDatastoreUuid or remoteVcUuid should not exist.  | 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine reference.  It exists if the object is backed by an virtual machine.  Refers instance of *VirtualMachine*.  | [optional] 
**SpbmProfileUuid** | **string** | UUID of SPBM profile.  It is used for identifying the policy of the object when it was applied to vSAN Object. Not set if the object doesn&#39;t use an SPBM managed policy. Unset if this profile is unidentified, it can happen when the object is not in a healthy state.  | [optional] 
**SpbmProfileName** | **string** | Name of SPBM profile.  It is used for the policy of the object when it was applied to vSAN Object. Not set if the object doesn&#39;t use an SPBM managed policy. Unset if this profile is unidentified, it can happen when the object is not in a healthy state.  | [optional] 
**IsLocalPolicy** | **bool** | Flag if the SPBM policy can be identified as a local policy.  Unset if this profile is unidentified. It can happen when the object is not in a healthy state.  | [optional] 
**RemoteDatastoreUuid** | **string** | Remote vSAN datastore UUID.  It exists only when the object is from remote vSAN datastore.  | [optional] 
**RemoteDatastoreName** | **string** | Remote vSAN datastore name.  It exists only when the object is from remote vSAN datastore.  | [optional] 
**RemoteCluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Remote vSAN cluster reference.  It exists only when the object is from remote vSAN cluster.  Refers instance of *ClusterComputeResource*.  | [optional] 
**RemoteClusterName** | **string** | Remote vSAN cluster name.  It exists only when the object is from remote vSAN cluster.  | [optional] 
**RemoteVc** | **string** | Remote VC identification.  It exists only when the object is mounted from a remote VC. This information is determined from the remote datastore source *VsanHciMeshDatastoreSource* when registering by *VsanRemoteDatastoreSystem.VsanCreateDatastoreSource* or vSphere UI.  | [optional] 
**HealthState** | **string** | The object health state.  This variable will be one of the enums pre-defined in vim.host.VsanObjectHealth.VsanObjectHealthState. Unset if the object health state can not be identified.  | [optional] 
**Components** | [**List&lt;VsanComponentPlacement&gt;**](VsanComponentPlacement.md) | Component placement details.  Unset if the object placement details can not be identified.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

