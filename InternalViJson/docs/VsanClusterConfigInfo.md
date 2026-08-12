# Vcenter.ViJson.OpenApi.Model.VsanClusterConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether the VSAN service is enabled for the cluster.  | [optional] 
**DefaultConfig** | [**VsanClusterConfigInfoHostDefaultInfo**](VsanClusterConfigInfoHostDefaultInfo.md) | Default VSAN settings to use for hosts admitted to the cluster when the VSAN service is enabled.  If omitted, values will default as though the fields in the *VsanClusterConfigInfoHostDefaultInfo* have been omitted.  See also *VsanClusterConfigInfo.enabled*, *VsanClusterConfigInfoHostDefaultInfo*.  | [optional] 
**VsanEsaEnabled** | **bool** | Whether the vSAN ESA is enabled for vSAN cluster.  This can only be enabled when vSAN is enabled on the cluster.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**VsanCyberRecoveryEnabled** | **bool** | Whether vSAN Cyber Recovery is enabled.  Cyber Recovery has not been configured and is disabled when it is omitted.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

