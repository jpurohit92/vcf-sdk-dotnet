# Vcenter.ViJson.OpenApi.Model.HostListSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The reference to the host-managed object.  Refers instance of *HostSystem*.  | [optional] 
**Hardware** | [**HostHardwareSummary**](HostHardwareSummary.md) | Basic hardware information, if known.  | [optional] 
**Runtime** | [**HostRuntimeInfo**](HostRuntimeInfo.md) | Basic runtime information, if known.  | [optional] 
**Config** | [**HostConfigSummary**](HostConfigSummary.md) | Basic configuration information, if known.  | 
**QuickStats** | [**HostListSummaryQuickStats**](HostListSummaryQuickStats.md) | Basic host statistics.  | 
**OverallStatus** | **ManagedEntityStatusEnum** | The overall alarm status of the host.  In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Since this property is on a DataObject, an update returned by WaitForUpdatesEx may contain values for this property when some other property on the DataObject changes. If this update is a result of a call to WaitForUpdatesEx with a non-empty version parameter, the value for this property may not be current.  | 
**RebootRequired** | **bool** | Indicates whether or not the host requires a reboot due to a configuration change.  | 
**RebootRequiredReason** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Indicates the reason, if available, for a pending reboot.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**MaintenanceModeRequired** | **bool** | Indicates whether or not the host requires entering and exiting maintenance mode due to a configuration change.  If unset, then no maintenance mode enter is pending.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**CustomValue** | [**List&lt;CustomFieldValue&gt;**](CustomFieldValue.md) | The customized field values.  | [optional] 
**ManagementServerIp** | **string** | IP address of the VirtualCenter server managing this host, if any.  | [optional] 
**MaxEVCModeKey** | **string** | The most capable Enhanced VMotion Compatibility mode supported by the host hardware and software; unset if this host cannot participate in any EVC mode.  See also *Capability.supportedEVCMode*.  | [optional] 
**CurrentEVCModeKey** | **string** | The Enhanced VMotion Compatibility mode that is currently in effect for this host.  If the host is in a cluster where EVC is active, this will match the cluster&#39;s EVC mode; otherwise this will be unset.  See also *Capability.supportedEVCMode*.  | [optional] 
**CurrentEVCGraphicsModeKey** | **string** | The Enhanced VMotion Compatibility Graphics mode that is currently in effect for this host.  If the host is in a cluster where EVC is active, this will match the cluster&#39;s EVC Graphics mode; otherwise this will be unset.  See also *Capability.supportedEVCGraphicsMode*.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**Gateway** | [**HostListSummaryGatewaySummary**](HostListSummaryGatewaySummary.md) | Gateway configuration, if vCenter server manages the host via a gateway  | [optional] 
**TpmAttestation** | [**HostTpmAttestationInfo**](HostTpmAttestationInfo.md) |  | [optional] 
**TrustAuthorityAttestationInfos** | [**List&lt;HostTrustAuthorityAttestationInfo&gt;**](HostTrustAuthorityAttestationInfo.md) | The attestation information for the host as retrieved from any Trust Authority attestation services configured in the host&#39;s parent compute resource.  This field will be set only if there is any Trust Authority attestation service configured for the host&#39;s parent compute resource, and unset otherwise.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

