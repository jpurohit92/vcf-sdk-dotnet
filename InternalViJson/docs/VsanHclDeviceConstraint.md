# Vcenter.ViJson.OpenApi.Model.VsanHclDeviceConstraint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PciId** | **string** | PCI ID of a vSAN device.  | 
**VcgLink** | **string** | VCG URL for the device.  In case this PCIe device is not certified by VMware VCG, this field will be empty.  | [optional] 
**SimilarVcgLinks** | **List&lt;string&gt;** | VCG URLs for similar device, with the same PCI ID.  Some vendors manufacture multiple PCIe devices with the same PCI ID, in case there&#39;re multiple devices of the same PCI ID certified by VMware VCG, this is the URL of those devices. Otherwise it will be empty.  | [optional] 
**CompliantFirmwares** | [**List&lt;VsanCompliantFirmware&gt;**](VsanCompliantFirmware.md) | vSAN compliant firmwares(and drivers) for this device.  | [optional] 
**VcgId** | **int** | Device id in the VCG portal.  | [optional] 
**Model** | **string** | Model of the device.  E.g., 1.2TB 10K 12Gbps SAS 2.5\&quot;  | [optional] 
**Partner** | **string** | Partner of the device.  E.g., Lenovo  | [optional] 
**PartNumber** | **string** | Part number of the device.  E.g., HDEBL02LPA51F  | [optional] 
**Release** | **string** | Certified VMware release.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

