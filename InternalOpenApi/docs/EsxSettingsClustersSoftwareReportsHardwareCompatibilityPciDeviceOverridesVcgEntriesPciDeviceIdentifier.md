# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityPciDeviceOverridesVcgEntriesPciDeviceIdentifier
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.PciDeviceOverrides.VcgEntries.PciDeviceIdentifier schema specifies a particular PCI device product its characteristic ID (VID/DID/SVID/SSID)  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vid** | **string** | The PCI device&#39;s Vendor ID (VID).    The VID is a unique number assigned by the PCI SIG to every PCI device vendor to identify the chipset manufacturer (e.g. for a NIC that might be Broadcom or Atheros). The VID and the Device ID (DID) below typically determine the choice of device driver.  This property was added in __vSphere API 7.0.3.0__. | 
**Did** | **string** | The PCI device&#39;s Device ID (DID).    The DID is assigned by the vendor to identify a particular device.  This property was added in __vSphere API 7.0.3.0__. | 
**Svid** | **string** | The PCI device&#39;s sub-vendor ID (SVID).    Where the VID identifies the chipset of a given card, the SVID identifies the card manufacturer (e.g. for a NIC, the card manufacturer might be Netgear or D-Link).    May be 0 to indicate the override should apply to all PCI devices of the specified VID/DID  This property was added in __vSphere API 7.0.3.0__. | 
**Ssid** | **string** | The PCI device&#39;s Subsystem ID (SSID).    The Subsystem ID is assigned by the subsystem vendor from the sam number space as the Device ID. The SVID and SSID together provide information the driver might use to apply a small card-specific changes in operation based on the card&#39;s unique characteristics.    May be 0 to indicate the override should apply to all PCI devices of the specified VID/DID  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

