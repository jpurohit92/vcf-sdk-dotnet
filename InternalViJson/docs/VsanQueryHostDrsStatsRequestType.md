# Vcenter.ViJson.OpenApi.Model.VsanQueryHostDrsStatsRequestType
The parameters of *VsanSystemEx.VsanQueryHostDrsStats*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostUuids** | **List&lt;string&gt;** | In regular vSAN cluster, it indicates sorted list of vSAN member host Uuid. It is used to determine the full set of vSAN member hosts and the sequence to organize vSAN VM stats. In stretched compute only cluster, it is an array filled by &#39;0&#39; and &#39;1&#39;, to indicate the host membership of configured site fault domains, this is to fill in the gap of absence of vSAN host fault domain on vSAN enabled node.  | [optional] 
**Vms** | **List&lt;string&gt;** | List of VM instance UUID. If specified, only stats of given VMs will be returned, otherwise all vSAN VMs registered on this host will be involved if this parameter is omitted. By default template VM will be ignored unless it is specified by this paramter.  | [optional] 
**HostIndex** | **int** | Only applicable to stretched compute only node, to indicate the index of the target host in parameter &#39;hostUuids&#39;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

