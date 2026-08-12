# Vcenter.ViJson.OpenApi.Model.VsanFileServicePreflightCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OvfInstalled** | **string** | This field indicates whether the file service OVF for running vSAN file services has been installed on the vCenter or not.  This field will show the highest OVF version present on this vCenter that is compatible to the cluster. This field will not be set if no compatible OVF version could be found on this vCenter.  | [optional] 
**FsvmVersion** | **string** | This field indicates current running file service OVF version used by vSAN file service.  It will only be present if there are file service VMs running in this cluster without mixed version.  | [optional] 
**LastUpgradeDate** | **DateTime** | This field indicates date file service VMs last upgraded.  | [optional] 
**OvfMixedModeIssue** | **string** | Field to indicate whether there are multiple file service VM ovf versions running.  This field will be left empty if there is no issue regarding the mixed OVF version file service VMs.  | [optional] 
**HostVersion** | **string** | Field to indicate the lowest host version in this cluster.  This filed will be left empty if there are no hosts in the cluster.  | [optional] 
**MixedModeIssue** | **string** | vSAN file service cannot be enabled when there is any host whose version is lower than minimum required host version in this cluster.  Minimum required host version is 7.0.0 in vSAN OSA cluster, or 8.0.2 in vSAN ESA cluster. This issue will be reported if any host whose version is lower than minimum required host version is detected. If this field is empty, it means that all the hosts in the cluster meet the version requirement.  | [optional] 
**NetworkPartitionIssue** | **string** | Issues regarding whether there are network partitions in the cluster.  This field will be left empty if there are no network partitions in this cluster.  | [optional] 
**VsanDatastoreIssue** | **string** | Checks whether the vSAN datastore is present to all the hosts to the cluster.  If hosts without vSAN datastore will be reported in this field. This field will be left empty if all the host in this cluster are with vSAN datastore.  | [optional] 
**DomainConfigIssue** | **string** | Checks whether the domain configuration is valid.  Currently the check includes the existence of the file server IP addresses, the correctness of file server AD domain username and password, the network connectivity of file server domain configuration. This field will only be present when the domain configuration issue is detected.  | [optional] 
**FileServiceVersion** | **string** | This field indicates the highest file service version that the cluster can support.  The field will be left empty if the cluster doesn&#39;t meet the requirement to enalbe file service.  | [optional] 
**DvsConfigIssue** | **string** | Checks whether the dvs configuration is valid.  This check validates if the supplied network for file service is dvsPortGroup, the DSwitch which is hosting the port group has version equal to or older then 6.6.0. This field will only be present when DVS configuration issue is detected.  | [optional] 
**DomainConfigWarning** | **string** | This field indicates the network connectivity between file server and gateway.  Currently, it will only be present when file server could not connect to gateway. As it is a warning, it won&#39;t block user to proceed.  | [optional] 
**NtpConfigWarning** | **string** | Checks whether the NTP is configured in ESXi hosts.  This field will only be present when the NTP is not configured in ESXi hosts. Without NTP configured, it won&#39;t block user to proceed while user might encounter failure later when joining Active Directory domain if time is out of sync.  | [optional] 
**SvsConfigIssue** | **string** | Checks whether the standard switch configuration is valid.  | [optional] 
**NsxConfigIssue** | **string** | Checks whether the nsx configuration is valid.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

