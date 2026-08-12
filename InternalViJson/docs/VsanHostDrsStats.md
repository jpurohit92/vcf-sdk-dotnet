# Vcenter.ViJson.OpenApi.Model.VsanHostDrsStats

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN host entity associated to the DRS stats.  Refers instance of *HostSystem*.  | 
**Stats** | **byte[]** | Binary value to present vSAN DRS stats in below C struct: typedef VmHostStat uint8; // vSAN VM read locality per host.  // 1 means the host can serve read request // without cross site IO, and 0 means // either the data is inaccessible to this // host or the host needs cross site read // to serve the read request. struct VmStats { Uuid vmUuid; // VM instance UUID; uint32 totalSizeInKb; // Total capacity used by this VM in KB on // vSAN datastore; VmHostStat perHostValue\\[0\\]; // Weight of VM active vSAN data contributed // per vSAN host. The order is determined by // host member list specified to API // VsanQueryHostDrsStats, and length is // determined by number of vSAN member hosts; }; struct Stats { uint64 hostCapInKb; // host capacity contributed to vSAN in KB; uint64 hostUsageInKb; // host usage on vSAN datastore in KB; uint32 numVms; // number of vSAN VMs registered on this host; uint32 numHosts; // number of vSAN member hosts; It is determined // by host member list specified to API // VsanQueryHostDrsStats. Any host member change // can be detected by vSAN VC service, and trigger // next stats query to capture the new change. VmStats perVmStats\\[0\\];// vSAN VM DRS stats, length is determined by // numVms; And note that size of VmStats struct // itself is dynamic. };  | 
**ReadLocalityPresented** | **bool** | Whether object site read locality is presented in VmStats  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

