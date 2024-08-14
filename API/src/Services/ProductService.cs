using D4C_API.Models.V1;
using static System.Net.WebRequestMethods;

namespace D4C_API.Services
{
    public class ProductService
    {
        private readonly List<Models.V1.Object> sampleProductsV1 =
        [
            //Knauf
            new Models.V1.Object{
                Id = "acdb59b2-f983-404a-80dc-53475fdaba93",
                Name = "Knauf MP 75 Plaster",
                Uri = new Uri("https://some-link-to-knauf.be/viewer/acdb59b2-f983-404a-80dc-53475fdaba93/Knauf_MP_75_Plaster"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 0.125 },
                            {"a4", 0.0166 },
                            {"a5", 0.0518 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", null },
                            {"c2", 0.0053 },
                            {"c3", 0.00122 },
                            {"c4", 0.000214 },
                            {"d", -0.00456 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 3.11e-8 },
                            { "a4", 3.14e-9},
                            { "a5", 1.28e-9},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 9.969e-10},
                            { "c3", 2.59e-10},
                            { "c4", 8.63e-11},
                            { "d", -8.45e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep_freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 1.27e-4 },
                            { "a4", 8.74e-6},
                            { "a5", 4.35e-6},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 2.79e-6},
                            { "c3", 1.18e-6},
                            { "c4", 3.02e-7},
                            { "d", -7.07e-7}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 2.36 },
                            { "a4", 2.53e-1},
                            { "a5", 9.05e-2},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 8.00e-2},
                            { "c3", 1.75e-2},
                            { "c4", 6.93e-3},
                            { "d", -7.59e-2}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_NC",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_NC"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 2.63e-8 },
                            { "a4", 2.55e-9},
                            { "a5", 1.21e-9},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 7.79e-10},
                            { "c3", 8.49e-11},
                            { "c4", 1.14e-11},
                            { "d", -1.49e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_C",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_C"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 7.41e-10 },
                            { "a4", 1.26e-10},
                            { "a5", 1.03e-10 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 3.88e-11},
                            { "c3", 2.72e-11},
                            { "c4", 2.07e-12},
                            { "d", -9.19e-12}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "U235",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/U235"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 6.37e-3 },
                            { "a4", 1.20e-3},
                            { "a5", 8.84e-4 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",3.75e-4},
                            { "c3",  2.63e-4},
                            { "c4", 3.26e-5},
                            { "d", -6.33e-7}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "eco-toxicityfreshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/eco-toxicityfreshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 4.38e-2 },
                            { "a4", 4.37e-2},
                            { "a5", 5.40e-3 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",1.32e-2},
                            { "c3",  4.64e-4},
                            { "c4", 1.09e-4},
                            { "d", -3.83e-4}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "SERL",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 60,
                    }
                ],
            },
            //Foamglass
            new Models.V1.Object{
                Id = "5214b728-b062-4662-9722-22ef1214c08c",
                Name = "Foamglas S3",
                Uri = new Uri("https://some-link-to-foamglass.be/viewer/5214b728-b062-4662-9722-22ef1214c08c/foamglas_s3"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/conversion-factor"),
                        Value = 20.80
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "esl",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/esl"),
                        Value = 100,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 5.57 },
                            { "a2", 8.86 },
                            { "a3", 2.15 },
                            {"a4",  5.45e-01 },
                            {"a5", 2.11 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", null },
                            {"c2", 7.49e-02 },
                            {"c3", 2.74e-01 },
                            {"c4", 5.11e-03 },
                            {"d", -7.48e-01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/odp"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 7.11e-07 },
                            { "a2", 1.99e-07 },
                            { "a3", 2.76e-06 },
                            { "a4", 1.23e-07},
                            { "a5", 8.54e-08},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.62e-08},
                            { "c2", 6.04e-08},
                            { "c3", 2.45e-10},
                            { "c4", 6.24e-08},
                            { "d", -1.02e-07}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep-freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/ep-freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.96e-04 },
                            { "a2",  6.73e-06 },
                            { "a3",  1.94e-04},
                            { "a4", 4.38e-06},
                            { "a5", 1.06e-05},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.73e-07},
                            { "c2", 2.76e-06},
                            { "c3", 3.19e-07},
                            { "c4", 3.43e-06},
                            { "d", -2.51e-05}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "adp-fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/adp-fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 7.77e+01 },
                            { "a2", 1.32e+01},
                            { "a3", 3.32e+02},
                            { "a4", 8.19},
                            { "a5", 9.33},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.03},
                            { "c2", 4.13},
                            { "c3", 6.61e-02},
                            { "c4", 4.74},
                            { "d", -1.61e+01}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "htp-nc",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/htp-nc"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.27e-07 },
                            { "a2", 1.12e-08 },
                            { "a3", 4.14e-07 },
                            { "a4", 7.17e-09},
                            { "a5", 1.4e-08},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 5.34e-10},
                            { "c2", 4.03e-09},
                            { "c3", 4.02e-11},
                            { "c4", 2.83e-09},
                            { "d", -3.8e-09}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "htp-c",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/htp-c"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 4.46e-09 },
                            { "a2", 3.24e-10 },
                            { "a3", 9.28e-09 },
                            { "a4", 1.89e-10},
                            { "a5", 3.49e-10 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.17e-11},
                            { "c2",  1.19e-10},
                            { "c3", 1.63e-12},
                            { "c4", 1.41e-10},
                            { "d", -1.11e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "irp",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/irp"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.48e-01 },
                            { "a2", 5.76e-02 },
                            { "a3", 8.69e-01 },
                            { "a4", 3.58e-02},
                            { "a5",  2.68e-02 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1",  4.42e-03},
                            { "c2",1.73e-02},
                            { "c3",  21.37e-04},
                            { "c4",1.85e-02},
                            { "d", -9.76e-02}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "etp-fw",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/etp-fw"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.66e+02 },
                            { "a2", 1.04e+01 },
                            { "a3", 3.14e+02 },
                            { "a4", 6.61},
                            { "a5", 1.49e+01 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 6.22e-01},
                            { "c2",3.68},
                            { "c3",  6.91e-02},
                            { "c4", 3.68 },
                            { "d", 1.28e-01}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "esl",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/esl"),
                        Value = 100,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF020017",
                        Unit = "W/(m·K)",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF020017"),
                        Value = 0.045,
                    }
                ],
            }
        ];

        private readonly List<Models.V1.Object> sampleProductsV2 =
        [
            //Knauf
            new Models.V1.Object{
                Id = "acdb59b2-f983-404a-80dc-53475fdaba93",
                Name = "Knauf MP 75 Plaster",
                Uri = new Uri("https://some-link-to-knauf.be/viewer/acdb59b2-f983-404a-80dc-53475fdaba93/Knauf_MP_75_Plaster"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 0.125 },
                            {"a4", 0.0166 },
                            {"a5", 0.0518 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", null },
                            {"c2", 0.0053 },
                            {"c3", 0.00122 },
                            {"c4", 0.000214 },
                            {"d", -0.00456 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 3.11e-8 },
                            { "a4", 3.14e-9},
                            { "a5", 1.28e-9},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 9.969e-10},
                            { "c3", 2.59e-10},
                            { "c4", 8.63e-11},
                            { "d", -8.45e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep_freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 1.27e-4 },
                            { "a4", 8.74e-6},
                            { "a5", 4.35e-6},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 2.79e-6},
                            { "c3", 1.18e-6},
                            { "c4", 3.02e-7},
                            { "d", -7.07e-7}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 2.36 },
                            { "a4", 2.53e-1},
                            { "a5", 9.05e-2},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 8.00e-2},
                            { "c3", 1.75e-2},
                            { "c4", 6.93e-3},
                            { "d", -7.59e-2}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_NC",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_NC"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 2.63e-8 },
                            { "a4", 2.55e-9},
                            { "a5", 1.21e-9},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 7.79e-10},
                            { "c3", 8.49e-11},
                            { "c4", 1.14e-11},
                            { "d", -1.49e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_C",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_C"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 7.41e-10 },
                            { "a4", 1.26e-10},
                            { "a5", 1.03e-10 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 3.88e-11},
                            { "c3", 2.72e-11},
                            { "c4", 2.07e-12},
                            { "d", -9.19e-12}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "U235",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/U235"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 6.37e-3 },
                            { "a4", 1.20e-3},
                            { "a5", 8.84e-4 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",3.75e-4},
                            { "c3",  2.63e-4},
                            { "c4", 3.26e-5},
                            { "d", -6.33e-7}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "eco-toxicityfreshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/eco-toxicityfreshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 4.38e-2 },
                            { "a4", 4.37e-2},
                            { "a5", 5.40e-3 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",1.32e-2},
                            { "c3",  4.64e-4},
                            { "c4", 1.09e-4},
                            { "d", -3.83e-4}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 0.125,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/conversion-factor"),
                        Value = 1
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "SERL",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 60,
                    }
                ],
            },
            //Foamglass
            new Models.V1.Object{
                Id = "5214b728-b062-4662-9722-22ef1214c08c",
                Name = "Foamglas S3",
                Uri = new Uri("https://some-link-to-foamglass.be/viewer/5214b728-b062-4662-9722-22ef1214c08c/foamglas_s3"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/conversion-factor"),
                        Value = 20.80
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "esl",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/esl"),
                        Value = 100,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 5.57 },
                            { "a2", 8.86 },
                            { "a3", 2.15 },
                            {"a4",  5.45e-01 },
                            {"a5", 2.11 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", null },
                            {"c2", 7.49e-02 },
                            {"c3", 2.74e-01 },
                            {"c4", 5.11e-03 },
                            {"d", -7.48e-01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/odp"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 7.11e-07 },
                            { "a2", 1.99e-07 },
                            { "a3", 2.76e-06 },
                            { "a4", 1.23e-07},
                            { "a5", 8.54e-08},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.62e-08},
                            { "c2", 6.04e-08},
                            { "c3", 2.45e-10},
                            { "c4", 6.24e-08},
                            { "d", -1.02e-07}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep-freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/ep-freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.96e-04 },
                            { "a2",  6.73e-06 },
                            { "a3",  1.94e-04},
                            { "a4", 4.38e-06},
                            { "a5", 1.06e-05},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.73e-07},
                            { "c2", 2.76e-06},
                            { "c3", 3.19e-07},
                            { "c4", 3.43e-06},
                            { "d", -2.51e-05}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "adp-fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/adp-fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 7.77e+01 },
                            { "a2", 1.32e+01},
                            { "a3", 3.32e+02},
                            { "a4", 8.19},
                            { "a5", 9.33},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.03},
                            { "c2", 4.13},
                            { "c3", 6.61e-02},
                            { "c4", 4.74},
                            { "d", -1.61e+01}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "htp-nc",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/htp-nc"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.27e-07 },
                            { "a2", 1.12e-08 },
                            { "a3", 4.14e-07 },
                            { "a4", 7.17e-09},
                            { "a5", 1.4e-08},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 5.34e-10},
                            { "c2", 4.03e-09},
                            { "c3", 4.02e-11},
                            { "c4", 2.83e-09},
                            { "d", -3.8e-09}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "htp-c",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/htp-c"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 4.46e-09 },
                            { "a2", 3.24e-10 },
                            { "a3", 9.28e-09 },
                            { "a4", 1.89e-10},
                            { "a5", 3.49e-10 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.17e-11},
                            { "c2",  1.19e-10},
                            { "c3", 1.63e-12},
                            { "c4", 1.41e-10},
                            { "d", -1.11e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "irp",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/irp"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.48e-01 },
                            { "a2", 5.76e-02 },
                            { "a3", 8.69e-01 },
                            { "a4", 3.58e-02},
                            { "a5",  2.68e-02 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1",  4.42e-03},
                            { "c2",1.73e-02},
                            { "c3",  21.37e-04},
                            { "c4",1.85e-02},
                            { "d", -9.76e-02}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "etp-fw",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/etp-fw"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.66e+02 },
                            { "a2", 1.04e+01 },
                            { "a3", 3.14e+02 },
                            { "a4", 6.61},
                            { "a5", 1.49e+01 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 6.22e-01},
                            { "c2",3.68},
                            { "c3",  6.91e-02},
                            { "c4", 3.68 },
                            { "d", 1.28e-01}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "conversion-factor",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/conversion-factor"),
                        Value = 20
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "esl",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/esl"),
                        Value = 100,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF020017",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF020017"),
                        Value = 100,
                    }
                ],
            },
            new Models.V1.Object{
                Id = "3712a4c7-e820-4f42-959b-963dsad7f20c/masterline_8",
                Name = "Reynaers Aluminium Masterline 8",
                Uri = new Uri("https://some-link-to-reynaers.be/viewer/3712a4c7-e820-4f42-959b-963dsad7f20c/masterline_8"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.24E+02 },
                            { "a2", 2.30E+00 },
                            { "a3", 2.97E+00 },
                            {"a4", 3.63E-01 },
                            {"a5", 6.11E+01 },
                            {"b1", null },
                            {"b2", 4.66E+00 },
                            {"b3", null },
                            {"b4", 3.78E+01 },
                            {"b5", null },
                            {"b6", 0.00E+00 },
                            {"b7", null },
                            {"c1", 0.00E+00 },
                            {"c2", 3.31E-01 },
                            {"c3", 1.65E-02 },
                            {"c4", 6.75E+00 },
                            {"d", -7.95E+01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.01E-05 },
                            { "a2", 5.23E-07 },
                            { "a3", 2.84E-07 },
                            { "a4", 8.12E-08},
                            { "a5", 4.57E-06},
                            { "b1", null},
                            { "b2", 6.91E-05},
                            { "b3", null},
                            { "b4", 5.84E-06},
                            { "b5", null},
                            { "b6", 0.00E+00},
                            { "b7", null},
                            { "c1", 0.00E+00},
                            { "c2", 7.52E-08},
                            { "c3", 3.34E-09},
                            { "c4", 2.55E-07},
                            { "d", -3.11E-06}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep_freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.41E-02 },
                            { "a2", 1.81E-05 },
                            { "a3", 7.73E-05 },
                            { "a4", 3.10E-06},
                            { "a5", 3.33E-03},
                            { "b1", null},
                            { "b2", 9.60E-03},
                            { "b3", null},
                            { "b4", 1.04E-03},
                            { "b5", null},
                            { "b6", 0.00E+00},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",  0.00E+00},
                            { "c3", 2.60E-06},
                            { "c4", 3.94E-07},
                            { "d", -2.32E-03}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.97E+03 },
                            { "a2", 3.47E+01 },
                            { "a3", 4.58E+01 },
                            { "a4", 5.43E+00 },
                            { "a5", 6.45E+02},
                            { "b1", null},
                            { "b2", 2.36E+01},
                            { "b3", null},
                            { "b4", 4.89E+02},
                            { "b5", null},
                            { "b6", 0.00E+00},
                            { "b7", null},
                            { "c1", 0.00E+00},
                            { "c2", 4.99E+00},
                            { "c3", 5.80E-01},
                            { "c4", 1.27E+01},
                            { "d", -7.70E+02}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "functional unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "conversion-factor",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/conversion-factor"),
                        Value = 32.259
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "SERL",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 60,
                    }
                ],
            },
];

        private readonly List<Models.V1.Object> sampleProductsV3 =
        [
            //Knauf
            new Models.V1.Object{
                Id = "acdb59b2-f983-404a-80dc-53475fdaba93",
                Name = "Knauf MP 75 Plaster",
                Uri = new Uri("https://some-link-to-knauf.be/viewer/acdb59b2-f983-404a-80dc-53475fdaba93/Knauf_MP_75_Plaster"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "organization",
                        Uri = new Uri("http://xmlns.com/foaf/0.1/Organization"),
                        Value = "Knauf",
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 0.125 },
                            {"a4", 0.0166 },
                            {"a5", 0.0518 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", null },
                            {"c2", 0.0053 },
                            {"c3", 0.00122 },
                            {"c4", 0.000214 },
                            {"d", -0.00456 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 3.11e-8 },
                            { "a4", 3.14e-9},
                            { "a5", 1.28e-9},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 9.969e-10},
                            { "c3", 2.59e-10},
                            { "c4", 8.63e-11},
                            { "d", -8.45e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep_freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 1.27e-4 },
                            { "a4", 8.74e-6},
                            { "a5", 4.35e-6},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 2.79e-6},
                            { "c3", 1.18e-6},
                            { "c4", 3.02e-7},
                            { "d", -7.07e-7}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 2.36 },
                            { "a4", 2.53e-1},
                            { "a5", 9.05e-2},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 8.00e-2},
                            { "c3", 1.75e-2},
                            { "c4", 6.93e-3},
                            { "d", -7.59e-2}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_NC",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_NC"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 2.63e-8 },
                            { "a4", 2.55e-9},
                            { "a5", 1.21e-9},
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 7.79e-10},
                            { "c3", 8.49e-11},
                            { "c4", 1.14e-11},
                            { "d", -1.49e-10}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_C",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_C"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 7.41e-10 },
                            { "a4", 1.26e-10},
                            { "a5", 1.03e-10 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2", 3.88e-11},
                            { "c3", 2.72e-11},
                            { "c4", 2.07e-12},
                            { "d", -9.19e-12}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "U235",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/U235"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 6.37e-3 },
                            { "a4", 1.20e-3},
                            { "a5", 8.84e-4 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",3.75e-4},
                            { "c3",  2.63e-4},
                            { "c4", 3.26e-5},
                            { "d", -6.33e-7}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "eco-toxicityfreshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/eco-toxicityfreshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1a3", 4.38e-2 },
                            { "a4", 4.37e-2},
                            { "a5", 5.40e-3 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",1.32e-2},
                            { "c3",  4.64e-4},
                            { "c4", 1.09e-4},
                            { "d", -3.83e-4}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 0.125,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/conversion-factor"),
                        Value = 1
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "SERL",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 60,
                    },
                     new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF026338",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF026338"),
                        Value = "A1",
                    }
                ],
            },
            //Foamglass
            new Models.V1.Object{
                Id = "5214b728-b062-4662-9722-22ef1214c08c",
                Name = "Foamglas S3",
                Uri = new Uri("https://some-link-to-foamglass.be/viewer/5214b728-b062-4662-9722-22ef1214c08c/foamglas_s3"),
                Properties = [
                    
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "organization",
                        Uri = new Uri("http://xmlns.com/foaf/0.1/Organization"),
                        Value = "Pittsburgh Corning Europe",
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "massconversionfactor",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/massconversionfactor"),
                        Value = 20.80
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "esl",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 100,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.57E+00 },
                            { "a2", 2.49E-01 },
                            { "a3", 6.20E+00 },
                            {"a4",  8.31E-02 },
                            {"a5", 3.80E-01 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 2.11E-02 },
                            {"c2", 9.52E-02 },
                            {"c3", 2.99E-03 },
                            {"c4", 8.18E-02 },
                            {"d", -1.76E-01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_fossil",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.55E+00 },
                            { "a2", 2.49E-01 },
                            { "a3", 5.81E+00 },
                            {"a4",  8.30E-02 },
                            {"a5", 2.61E-01 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 2.11E-02 },
                            {"c2", 9.51E-02 },
                            {"c3", 2.98E-03 },
                            {"c4", 7.53E-02 },
                            {"d", -3.10E-01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_biogenic",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_biogenic"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.71E-02 },
                            { "a2", 1.12E-04 },
                            { "a3", 3.37E-01 },
                            {"a4",  4.30E-05 },
                            {"a5", 1.17E-01 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 5.86E-06 },
                            {"c2", 5.07E-05 },
                            {"c3", 8.53E-06 },
                            {"c4", 6.44E-03 },
                            {"d", 1.36E-01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_luluc",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_luluc"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.07E-03 },
                            { "a2", 9.74E-05 },
                            { "a3", 4.95E-02 },
                            {"a4",  3.17E-05 },
                            {"a5", 1.02E-03 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 1.66E-06 },
                            {"c2", 3.32E-05 },
                            {"c3", 1.47E-06 },
                            {"c4", 2.96E-05 },
                            {"d", -8.61E-04 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CFC11 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.00E-07 },
                            { "a2", 5.60E-08 },
                            { "a3", 7.85E-07 },
                            { "a4", 1.86E-08 },
                            { "a5", 2.29E-08 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 4.55E-09 },
                            { "c2", 2.16E-08 },
                            { "c3", 6.37E-10 },
                            { "c4", 2.02E-08 },
                            { "d", -4.00E-08 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "mol H+ eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/AE"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 9.61E-03 },
                            { "a2", 1.53E-03 },
                            { "a3", 2.84E-02 },
                            { "a4", 3.37E-04 },
                            { "a5", 8.56E-04 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.20E-04 },
                            { "c2", 3.88E-04 },
                            { "c3", 2.68E-05 },
                            { "c4", 5.53E-04 },
                            { "d", -1.23E-03 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_freshwater",
                        Unit = "kg PO4³ eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 8.33E-05 },
                            { "a2", 1.89E-06 },
                            { "a3", 5.47E-05 },
                            { "a4", 6.94E-07 },
                            { "a5", 2.90E-06 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 7.67E-08 },
                            { "c2", 7.47E-07 },
                            { "c3", 2.38E-08 },
                            { "c4", 1.25E-06 },
                            { "d", -1.30E-05 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_marine",
                        Unit = "kg N eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_marine"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 4.96E-03 },
                            { "a2", 4.10E-04 },
                            { "a3", 6.66E-03 },
                            { "a4", 9.84E-05 },
                            { "a5", 2.64E-04 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 9.73E-05 },
                            { "c2", 1.15E-04 },
                            { "c3", 1.15E-05 },
                            { "c4", 1.83E-04 },
                            { "d", -2.11E-04 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_terrestrial",
                        Unit = "mol N eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_terrestrial"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.34E-02 },
                            { "a2", 4.55E-03 },
                            { "a3", 8.68E-02 },
                            { "a4", 1.09E-03 },
                            { "a5", 2.55E-03 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.07E-03 },
                            { "c2", 1.27E-03 },
                            { "c3", 1.27E-04 },
                            { "c4", 2.01E-03 },
                            { "d", -2.46E-03 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "POCP",
                        Unit = "kg NMVOC eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/POCP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 4.91E-03 },
                            { "a2", 1.33E-03 },
                            { "a3", 1.99E-02 },
                            { "a4", 3.34E-04 },
                            { "a5", 5.94E-04 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.93E-04 },
                            { "c2", 3.90E-04 },
                            { "c3", 3.48E-05 },
                            { "c4", 6.04E-04 },
                            { "d", -8.37E-04 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "kg Sb eq",
                        Unit = "kg Sb eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_MM"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.29E-05 },
                            { "a2", 4.65E-07 },
                            { "a3", 3.87E-06 },
                            { "a4", 1.83E-07 },
                            { "a5", 7.62E-07 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 5.39E-09 },
                            { "c2", 1.85E-07 },
                            { "c3", 2.13E-09 },
                            { "c4", 1.08E-07 },
                            { "d", -3.48E-07 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "MJ",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.19E+01 },
                            { "a2", 3.71E+00 },
                            { "a3", 9.39E+01 },
                            { "a4", 1.25E+00 },
                            { "a5", 2.54E+00 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.90E-01 },
                            { "c2", 1.43E+00 },
                            { "c3", 5.48E-02 },
                            { "c4", 1.57E+00 },
                            { "d", -7.87E+00 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "FW",
                        Unit = "m³",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/FW"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.29E+00 },
                            { "a2", 1.01E-02 },
                            { "a3", 4.88E-01 },
                            { "a4", 3.61E-03 },
                            { "a5", 3.58E-02 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 3.89E-04 },
                            { "c2", 3.99E-03 },
                            { "c3", 2.50E-04 },
                            { "c4", 1.33E-02 },
                            { "d", -2.04E-01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "PM",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/PM"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.02E-07 },
                            { "a2", 1.65E-08 },
                            { "a3", 4.88E-01 },
                            { "a4", 5.49E-09 },
                            { "a5", 7.18E-09 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 5.83E-09 },
                            { "c2", 6.61E-09 },
                            { "c3", 6.81E-10 },
                            { "c4", 1.38E-08 },
                            { "d", -1.17E-08 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "U235",
                        Unit = "kBq U235 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/U235"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 6.98E-02 },
                            { "a2", 1.62E-02 },
                            { "a3", 2.46E-01 },
                            { "a4", 5.44E-03 },
                            { "a5", 7.24E-03 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.24E-03 },
                            { "c2", 6.27E-03 },
                            { "c3", 3.84E-04 },
                            { "c4", 5.91E-03 },
                            { "d", -5.04E-02 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "eco-toxicityfreshwater",
                        Unit = "CTUe",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/eco-toxicityfreshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.03E+02 },
                            { "a2", 2.94E+00 },
                            { "a3", 8.63E+01 },
                            { "a4", 1.02E+00 },
                            { "a5", 4.00E+00 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.75E-01 },
                            { "c2", 1.15E+00 },
                            { "c3", 3.02E-02 },
                            { "c4", 1.62E+00 },
                            { "d", -2.38E+00 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_C",
                        Unit = "CTUh",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_C"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.26E-09 },
                            { "a2", 9.10E-11 },
                            { "a3", 2.60E-09 },
                            { "a4", 2.99E-11 },
                            { "a5", 8.95E-11 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 6.11E-12 },
                            { "c2", 3.23E-11 },
                            { "c3", 1.06E-12 },
                            { "c4", 8.29E-11 },
                            { "d", -1.26E-10 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "CTUh_NC",
                        Unit = "CTUh",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/CTUh_NC"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.56E-08 },
                            { "a2", 3.16E-09 },
                            { "a3", 1.17E-07 },
                            { "a4", 1.10E-09 },
                            { "a5", 3.52E-09 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.50E-10 },
                            { "c2", 1.25E-09 },
                            { "c3", 2.42E-11 },
                            { "c4", 1.46E-09 },
                            { "d", -2.59E-09 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "SQI",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SQI"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 8.92E+00 },
                            { "a2", 2.41E+00 },
                            { "a3", 2.75E+02 },
                            { "a4", 8.12E-01 },
                            { "a5", 5.86E+00 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 3.70E-02 },
                            { "c2", 9.88E-01 },
                            { "c3", 1.86E-02 },
                            { "c4", 2.91E+00 },
                            { "d", -1.32E+01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "renewableprimaryresourceswithenergycontent-total",
                        Unit = "MJ",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/renewableprimaryresourceswithenergycontent-total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.22E+00 },
                            { "a2", 5.07E-02 },
                            { "a3", 9.20E+01 },
                            { "a4", 1.90E-02 },
                            { "a5", -1.28E+00 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.57E-03 },
                            { "c2", 2.02E-02 },
                            { "c3", 2.55E-03 },
                            { "c4", 2.54E-02 },
                            { "d", -2.57E+00 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "non-renewableprimaryresourceswithenergycontent-tot",
                        Unit = "MJ",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/non-renewableprimaryresourceswithenergycontent-tot"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.51E+01 },
                            { "a2", 3.74E+00 },
                            { "a3", 1.07E+02 },
                            { "a4", 1.26E+00 },
                            { "a5", 6.31E-01 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 2.89E-01 },
                            { "c2", 1.45E+00 },
                            { "c3", 5.59E-02 },
                            { "c4", 1.63E+00 },
                            { "d", -8.72E+00 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF020017",
                        Unit = "W/(m·K)",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF020017"),
                        Value = 0.045,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF025346",
                        Unit = "(m²·K)/W",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF025346"),
                        Value = 1.1111,
                    }
                ],
            },
            //Reynaers
            new Models.V1.Object{
                Id = "3712a4c7-e820-4f42-959b-963dsad7f20c/masterline_8",
                Name = "Reynaers Aluminium Masterline 8",
                Uri = new Uri("https://some-link-to-reynaers.be/viewer/3712a4c7-e820-4f42-959b-963dsad7f20c/masterline_8"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.24E+02 },
                            { "a2", 2.30E+00 },
                            { "a3", 2.97E+00 },
                            {"a4", 3.63E-01 },
                            {"a5", 6.11E+01 },
                            {"b1", null },
                            {"b2", 4.66E+00 },
                            {"b3", null },
                            {"b4", 3.78E+01 },
                            {"b5", null },
                            {"b6", 0.00E+00 },
                            {"b7", null },
                            {"c1", 0.00E+00 },
                            {"c2", 3.31E-01 },
                            {"c3", 1.65E-02 },
                            {"c4", 6.75E+00 },
                            {"d", -7.95E+01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.01E-05 },
                            { "a2", 5.23E-07 },
                            { "a3", 2.84E-07 },
                            { "a4", 8.12E-08},
                            { "a5", 4.57E-06},
                            { "b1", null},
                            { "b2", 6.91E-05},
                            { "b3", null},
                            { "b4", 5.84E-06},
                            { "b5", null},
                            { "b6", 0.00E+00},
                            { "b7", null},
                            { "c1", 0.00E+00},
                            { "c2", 7.52E-08},
                            { "c3", 3.34E-09},
                            { "c4", 2.55E-07},
                            { "d", -3.11E-06}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep_freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.41E-02 },
                            { "a2", 1.81E-05 },
                            { "a3", 7.73E-05 },
                            { "a4", 3.10E-06},
                            { "a5", 3.33E-03},
                            { "b1", null},
                            { "b2", 9.60E-03},
                            { "b3", null},
                            { "b4", 1.04E-03},
                            { "b5", null},
                            { "b6", 0.00E+00},
                            { "b7", null},
                            { "c1", 0},
                            { "c2",  0.00E+00},
                            { "c3", 2.60E-06},
                            { "c4", 3.94E-07},
                            { "d", -2.32E-03}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.97E+03 },
                            { "a2", 3.47E+01 },
                            { "a3", 4.58E+01 },
                            { "a4", 5.43E+00 },
                            { "a5", 6.45E+02},
                            { "b1", null},
                            { "b2", 2.36E+01},
                            { "b3", null},
                            { "b4", 4.89E+02},
                            { "b5", null},
                            { "b6", 0.00E+00},
                            { "b7", null},
                            { "c1", 0.00E+00},
                            { "c2", 4.99E+00},
                            { "c3", 5.80E-01},
                            { "c4", 1.27E+01},
                            { "d", -7.70E+02}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "functional unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "conversion-factor",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/bw/D4C-LCA/0.1/prop/conversion-factor"),
                        Value = 32.259
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "SERL",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 60,
                    }
                ],
            },
            //Menuiserie Riche
            new Models.V1.Object{
                Id = "f6de7fe3-be51-4874-be5f-6cddc9df1aca",
                Name = "Menuiserie Riche Wood Aluminium Window",
                Uri = new Uri("https://some-link-to-menuiresie-riche.be/viewer/f6de7fe3-be51-4874-be5f-6cddc9df1aca"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "functional unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "SERL",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 60,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5c"),
                        Name = "hasSubElement",
                        Uri = new Uri("https://w3id.org/bot#hasSubElement"),
                        Value = new List<string>(){ "https://some-link-to-menuiresie-riche.be/viewer/db56d427-8a8a-44d9-8b51-2b562d057138", "https://some-link-to-generic.be/viewer/f5f409f97-e324-4598-8663-79001b090189" },
                    }
                ],
            },
            //Double Glazing
            new Models.V1.Object{
                Id = "f5f409f97-e324-4598-8663-79001b090189",
                Name = "Generic Double Glazing",
                Uri = new Uri("https://some-link-to-generic.be/viewer/f5f409f97-e324-4598-8663-79001b090189"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.81E+01 },
                            { "a2", 2.95E-01 },
                            { "a3", 0.00E+00 },
                            {"a4", 2.10E-01 },
                            {"a5", 0.00E+00 },
                            {"b1", 0.00E+00 },
                            {"b2", 0.00E+00 },
                            {"b3", 0.00E+00 },
                            {"b4", 2.16E+01 },
                            {"b5", 0.00E+00 },
                            {"b6", 0.00E+00 },
                            {"b7", 0.00E+00 },
                            {"c1", 2.05E-01 },
                            {"c2", 1.57E-01 },
                            {"c3", 2.04E-02 },
                            {"c4", 9.59E-01 },
                            {"d", -1.63E+01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.97E-06 },
                            { "a2", 6.70E-08 },
                            { "a3", 0.00E+00 },
                            { "a4", 4.76E-08},
                            {"a5", 0.00E+00 },
                            {"b1", 0.00E+00 },
                            {"b2", 0.00E+00 },
                            {"b3", 0.00E+00 },
                            {"b4", 1.24E-04 },
                            {"b5", 0.00E+00 },
                            {"b6", 0.00E+00 },
                            {"b7", 0.00E+00 },
                            { "c1", 4.38E-08},
                            { "c2", 3.57E-08},
                            { "c3", 4.27E-09},
                            { "c4", 5.23E-08},
                            { "d", -1.84E-06}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep_freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 4.64E-04 },
                            { "a2", 2.32E-06 },
                            { "a3", 0.00E+00 },
                            { "a4", 1.65E-06},
                            {"a5", 0.00E+00 },
                            {"b1", 0.00E+00 },
                            {"b2", 0.00E+00 },
                            {"b3", 0.00E+00 },
                            {"b4", 5.19E-04 },
                            {"b5", 0.00E+00 },
                            {"b6", 0.00E+00 },
                            {"b7", 0.00E+00 },
                            { "c1", 7.38E-07 },
                            { "c2",  1.23E-06},
                            { "c3", 2.72E-07},
                            { "c4", 2.87E-06},
                            { "d", -3.07E-04}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.18E+02 },
                            { "a2", 4.45E+00 },
                            { "a3", 0.00E+00 },
                            { "a4", 3.16E+00 },
                            {"a5", 0.00E+00 },
                            {"b1", 0.00E+00 },
                            {"b2", 0.00E+00 },
                            {"b3", 0.00E+00 },
                            {"b4", 2.50E+02 },
                            {"b5", 0.00E+00 },
                            {"b6", 0.00E+00 },
                            {"b7", 0.00E+00 },
                            { "c1", 2.79E+00},
                            { "c2", 2.37E+00},
                            { "c3", 4.83E-01},
                            { "c4", 3.91E+00},
                            { "d", -1.82E+02}
                        },
                    },
                ],
            },
            //Menuiserie Riche Wood Aluminium Frame
            new Models.V1.Object{
                Id = "db56d427-8a8a-44d9-8b51-2b562d057138",
                Name = "Menuiserie Riche Wood Aluminium Frame",
                Uri = new Uri("https://some-link-to-menuiresie-riche.be/viewer/db56d427-8a8a-44d9-8b51-2b562d057138"),
                Properties = [
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.85E+01 },
                            {"a2", 4.89E+00},
                            {"a3", 2.75E+01},
                            {"a4", 2.36E-01},
                            {"a5", 2.85E+00},
                            {"b1", 0.00E+00},
                            {"b2", 0.00E+00},
                            {"b3", 0.00E+00},
                            {"b4", 0.00E+00},
                            {"b5", 0.00E+00},
                            {"b6", 0.00E+00},
                            {"b7", 0.00E+00},
                            {"c1", 2.04E-01},
                            {"c2", 2.67E-01},
                            {"c3", 3.07E+01},
                            {"c4", 3.48E+00},
                            {"d", -6.00E+01}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.26E-04 },
                            { "a2", 1.02E-06 },
                            { "a3", 1.64E-06 },
                            { "a4", 5.35E-08},
                            { "a5", 2.74E-07},
                            { "b1", 0.00E+00},
                            { "b2", 0.00E+00},
                            { "b3", 0.00E+00},
                            { "b4", 0.00E+00},
                            { "b5", 0.00E+00},
                            { "b6", 0.00E+00},
                            { "b7", 0.00E+00},
                            { "c1", 4.37E-08},
                            { "c2", 6.07E-08},
                            { "c3", 1.57E-08},
                            { "c4", 8.79E-09},
                            { "d", -2.59E-06}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ep_freshwater",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.86E-03 },
                            { "a2", 6.57E-05 },
                            { "a3", 2.06E-04 },
                            { "a4", 1.85E-06},
                            { "a5", 7.21E-05},
                            { "b1", 0.00E+00},
                            { "b2", 0.00E+00},
                            { "b3", 0.00E+00},
                            { "b4", 0.00E+00},
                            { "b5", 0.00E+00},
                            { "b6", 0.00E+00},
                            { "b7", 0.00E+00},
                            { "c1", 7.37E-07},
                            { "c2", 2.10E-06},
                            { "c3", 2.04E-06},
                            { "c4", 8.25E-07},
                            { "d", -1.81E-03}
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "kg CO2 eq.",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 8.54E+02 },
                            { "a2", 7.25E+01 },
                            { "a3", 3.14E+02 },
                            { "a4", 3.55E+00 },
                            { "a5", 4.04E+01 },
                            { "b1", 0.00E+00},
                            { "b2", 0.00E+00},
                            { "b3", 0.00E+00},
                            { "b4", 0.00E+00},
                            { "b5", 0.00E+00},
                            { "b6", 0.00E+00},
                            { "b7", 0.00E+00},
                            { "c1", 2.79E+00},
                            { "c2", 4.03E+00},
                            { "c3", 1.42E+00},
                            { "c4", 4.26E-01},
                            { "d", -6.23E+02}
                        },
                    }
                ]
            },

            //BFF - Ceramic Blocks
            new Models.V1.Object{
                Id = "5214b728-b062-4662-9722-22ef1214c08c",
                Name = "Belgian ceramic blocks",
                Uri = new Uri("https://appsm.health.belgium.be/ords/01/f?p=174:710:6163330152498::NO:::"),
                Properties = [

                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "organization",
                        Uri = new Uri("http://xmlns.com/foaf/0.1/Organization"),
                        Value = "Belgische Baksteenfederatie - Fédération Belge de la Brique",
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "massconversionfactor",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/massconversionfactor"),
                        Value = 67
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "esl",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 150,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5a"),
                        Name = "EF016887",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF016887"),
                        Value = 800,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 20.55 },
                            { "a2", 16.61 },
                            { "a3", 37.26 },
                            {"a4",  15.8 },
                            {"a5", 21.31 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 3.29 },
                            {"c2", 5.42 },
                            {"c3", 1.8 },
                            {"c4", 2.93 },
                            {"d", -3.32 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_fossil",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 15.57 },
                            { "a2", 16.61 },
                            { "a3", 21.12 },
                            {"a4",  15.8 },
                            {"a5", 12.71 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 3.29 },
                            {"c2", 5.42 },
                            {"c3", 1.79 },
                            {"c4", 2.93 },
                            {"d", -1.56 }
                        },
                    },
                    /*new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_biogenic",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_biogenic"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.71E-02 },
                            { "a2", 1.12E-04 },
                            { "a3", 3.37E-01 },
                            {"a4",  4.30E-05 },
                            {"a5", 1.17E-01 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 5.86E-06 },
                            {"c2", 5.07E-05 },
                            {"c3", 8.53E-06 },
                            {"c4", 6.44E-03 },
                            {"d", 1.36E-01 }
                        },
                    },*/
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_luluc",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_luluc"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.84e-03 },
                            { "a2", 5.18e-05 },
                            { "a3", 4.31e-02 },
                            {"a4",  5.25e-03 },
                            {"a5", 3.40e-03 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 1.17e-06 },
                            {"c2", 1.89e-03 },
                            {"c3", 2.79e-03 },
                            {"c4", 1.35e-04 },
                            {"d", -5.62e-03 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CFC11 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.50e-06 },
                            { "a2", 6.77e-06 },
                            { "a3", 1.21e-05 },
                            { "a4", 3.62e-06 },
                            { "a5", 1.16e-06 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 7.10e-07 },
                            { "c2", 1.23e-06 },
                            { "c3", 3.37e-07 },
                            { "c4", 1.21e-07 },
                            { "d", -3.56e-07 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "mol H+ eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/AE"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 8.74e-02 },
                            { "a2", 6.79e-02 },
                            { "a3", 1.68e-01 },
                            { "a4", 6.50e-02 },
                            { "a5", 9.80e-02 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 3.44e-02 },
                            { "c2", 2.11e-02 },
                            { "c3", 1.02e-02 },
                            { "c4", 2.54e-03 },
                            { "d", -3.15e-02 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_freshwater",
                        Unit = "kg PO4³ eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 3.36e-04 },
                            { "a2", 1.30e-04 },
                            { "a3", 5.52e-04 },
                            { "a4", 1.23e-04 },
                            { "a5", 6.35e-05 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.20e-05 },
                            { "c2", 4.25e-05 },
                            { "c3", 5.72e-05 },
                            { "c4", 3.00e-06 },
                            { "d", -1.42e-04 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_marine",
                        Unit = "kg N eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_marine"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.24e-02 },
                            { "a2", 2.01e-02 },
                            { "a3", 6.83e-02 },
                            { "a4", 1.94e-02 },
                            { "a5", 8.49e-03 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.52e-02 },
                            { "c2", 6.57e-03 },
                            { "c3", 3.46e-03 },
                            { "c4", 9.54e-04 },
                            { "d", -8.45e-03 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_terrestrial",
                        Unit = "mol N eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_terrestrial"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 2.87e-01 },
                            { "a2", 2.31e-01 },
                            { "a3", 9.78e-01 },
                            { "a4", 2.14e-01 },
                            { "a5", 9.72e-02 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 1.67e-01 },
                            { "c2", 7.26e-02 },
                            { "c3", 3.88e-02 },
                            { "c4", 1.05e-02 },
                            { "d", -1.12e-01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "POCP",
                        Unit = "kg NMVOC eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/POCP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 7.45e-02 },
                            { "a2", 6.82e-02 },
                            { "a3", 3.45e-01 },
                            { "a4", 6.67e-02 },
                            { "a5", 3.11e-02 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 4.58e-02 },
                            { "c2", 2.22e-02 },
                            { "c3", 1.06e-02 },
                            { "c4", 2.99e-03 },
                            { "d", -2.94e-02 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "kg Sb eq",
                        Unit = "kg Sb eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_MM"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.02e-04 },
                            { "a2", 3.24e-05 },
                            { "a3", 5.31e-05 },
                            { "a4", 2.72e-05 },
                            { "a5", 1.16e-05 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 8.41e-07 },
                            { "c2", 1.06e-05 },
                            { "c3", 2.74e-06 },
                            { "c4", 2.87e-07 },
                            { "d", -2.64e-05 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "MJ",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.26e+02 },
                            { "a2", 2.51e+02 },
                            { "a3", 1.49e+03 },
                            { "a4", 2.40e+02 },
                            { "a5", 1.14e+02 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 4.52e+01 },
                            { "c2", 8.17e+01 },
                            { "c3", 4.90e+01 },
                            { "c4", 9.17e+00 },
                            { "d", -3.51e+01 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "FW",
                        Unit = "m³",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/FW"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.93e+00 },
                            { "a2", 6.97e-01 },
                            { "a3", 1.01e+01 },
                            { "a4", 7.11e-01 },
                            { "a5", 7.20e+00 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 6.06e-02 },
                            { "c2", 2.27e-01 },
                            { "c3", 4.09e-01 },
                            { "c4", 3.91e-02 },
                            { "d", -1.65e+00 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF010130",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF010130"),
                        Value = "F2",
                    },
                ],
            },

            //Belgian ceramic facing bricks and pavers
            new Models.V1.Object{
                Id = "5214b728-b062-4662-9722-22ef1214c08c",
                Name = "Belgian ceramic facing bricks and pavers",
                Uri = new Uri("https://appsm.health.belgium.be/ords/01/f?p=174:710:6163330152498::NO:::"),
                Properties = [

                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "organization",
                        Uri = new Uri("http://xmlns.com/foaf/0.1/Organization"),
                        Value = "Belgische Baksteenfederatie - Fédération Belge de la Brique",
                    },
                    new Property
                    {
                        Id = new Guid("c6ab50c2-7eeb-4a2a-b081-f5349a721e96"),
                        Name = "referenceunittype",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referenceunittype"),
                        Value = "declared unit",
                    },
                    new Property
                    {
                        Id = new Guid("046ded57-84df-4d77-b8e8-e11bc18fe426"),
                        Name = "referencequantityarea",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/referencequantityarea"),
                        Value = 1,
                        Unit = "m2"
                    },
                    new Property
                    {
                        Id = new Guid("a6893d13-8ef9-4b1b-8ed6-f72ad9640eb2"),
                        Name = "massconversionfactor",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/massconversionfactor"),
                        Value = 187
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "esl",
                        Unit = "yr",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/SERL"),
                        Value = 150,
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_total",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_total"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 21 },
                            { "a2", 22.1 },
                            { "a3", 210 },
                            {"a4",  15.8 },
                            {"a5", 26.2 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 3.29 },
                            {"c2", 5.42 },
                            {"c3", 1.52 },
                            {"c4", 0.279 },
                            {"d", -4.2 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_fossil",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 18.7 },
                            { "a2", 22.1 },
                            { "a3", 216 },
                            {"a4",  15.4 },
                            {"a5", 10.8 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 3.29 },
                            {"c2", 5.42 },
                            {"c3", 1.51 },
                            {"c4", 0.278 },
                            {"d", -4.19 }
                        },
                    },
                    /*new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_biogenic",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_biogenic"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 1.71E-02 },
                            { "a2", 1.12E-04 },
                            { "a3", 3.37E-01 },
                            {"a4",  4.30E-05 },
                            {"a5", 1.17E-01 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 5.86E-06 },
                            {"c2", 5.07E-05 },
                            {"c3", 8.53E-06 },
                            {"c4", 6.44E-03 },
                            {"d", 1.36E-01 }
                        },
                    },*/
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "GWP_luluc",
                        Unit = "kg CO2 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/GWP_luluc"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.0236 },
                            { "a2", 0.000102 },
                            { "a3", 0.0446 },
                            {"a4",  0.00525 },
                            {"a5", -0.00438 },
                            {"b1", null },
                            {"b2", null },
                            {"b3", null },
                            {"b4", null },
                            {"b5", null },
                            {"b6", null },
                            {"b7", null },
                            {"c1", 0.0000294 },
                            {"c2", 0.00189 },
                            {"c3", 0.00276 },
                            {"c4", 0.000152 },
                            {"d", -0.0074 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "kg CFC11 eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ODP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.0000019 },
                            { "a2", 0.00000495 },
                            { "a3", 0.0000311 },
                            { "a4", 0.00000362 },
                            { "a5", 0.00000219 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 7.1e-7 },
                            { "c2", 0.00000123 },
                            { "c3", 2.78e-7 },
                            { "c4", 1.18e-7 },
                            { "d", -4.57e-7 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ODP",
                        Unit = "mol H+ eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/AE"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.162 },
                            { "a2", 0.0912 },
                            { "a3", 1.76 },
                            { "a4", 0.065 },
                            { "a5", 0.107 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0.0341 },
                            { "c2", 0.0342 },
                            { "c3", 0.00736 },
                            { "c4", 0.00239 },
                            { "d", -0.0389 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_freshwater",
                        Unit = "kg PO4³ eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_freshwater"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.000914 },
                            { "a2", 0.000182 },
                            { "a3", 0.000588 },
                            { "a4", 0.000123 },
                            { "a5", 0.0000995 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0.000012 },
                            { "c2", 0.0000425},
                            { "c3", 0.0000562 },
                            { "c4", 0.00000294 },
                            { "d", -0.000193 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_marine",
                        Unit = "kg N eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_marine"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.0344 },
                            { "a2", 0.0313 },
                            { "a3", 0.068 },
                            { "a4", 0.0194 },
                            { "a5", 0.00868 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0.0167 },
                            { "c2", 0.0249 },
                            { "c3", 0.00988 },
                            { "c4", 0.00312 },
                            { "d", -0.0104 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EP_terrestrial",
                        Unit = "mol N eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/EP_terrestrial"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.418 },
                            { "a2", 0.346 },
                            { "a3", 0.792 },
                            { "a4", 0.214 },
                            { "a5", 0.101 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0.176 },
                            { "c2", 0.249 },
                            { "c3", 0.090 },
                            { "c4", 0.0038 },
                            { "d", -0.136 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "POCP",
                        Unit = "kg NMVOC eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/POCP"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.112 },
                            { "a2", 0.103 },
                            { "a3", 0.343 },
                            { "a4", 0.0667 },
                            { "a5", 0.0347 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0.0458 },
                            { "c2", 0.0222 },
                            { "c3", 0.00678 },
                            { "c4", 0.00279 },
                            { "d", -0.0368 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "kg Sb eq",
                        Unit = "kg Sb eq",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_MM"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 0.000368 },
                            { "a2", 0.0000419 },
                            { "a3", 0.000053 },
                            { "a4", 0.0000272 },
                            { "a5", 0.0000263 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 8.41e-7 },
                            { "c2", 0.0000106 },
                            { "c3", 0.00000267 },
                            { "c4", 2.83e-7 },
                            { "d", -0.0000305 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "ADP_fossil",
                        Unit = "MJ",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/ADP_fossil"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 214 },
                            { "a2", 330 },
                            { "a3", 3230 },
                            { "a4", 240 },
                            { "a5", 209 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 45.2 },
                            { "c2", 81.7 },
                            { "c3", 45.2 },
                            { "c4", 8.97 },
                            { "d", -61.7 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "FW",
                        Unit = "m³",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/LCA/LCA/3.0/prop/FW"),
                        Value = new Dictionary<string, object?>{
                            { "a1", 11.8 },
                            { "a2", 0.943 },
                            { "a3", 15 },
                            { "a4", 0.711 },
                            { "a5", 1.47 },
                            { "b1", null},
                            { "b2", null},
                            { "b3", null},
                            { "b4", null},
                            { "b5", null},
                            { "b6", null},
                            { "b7", null},
                            { "c1", 0.0606 },
                            { "c2", 0.227 },
                            { "c3", 0.404 },
                            { "c4", 0.0388 },
                            { "d", -1.61 }
                        },
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF016887",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF016887"),
                        Value = "1200",
                    },
                    new Property
                    {
                        Id = new Guid("06cff420-2433-4ce7-a67e-24e42a385b5b"),
                        Name = "EF010130",
                        Uri = new Uri("https://identifier.buildingsmart.org/uri/etim/etim/9.0/prop/EF010130"),
                        Value = "F2",
                    }
                ],
            },
];

        public ProductService()
        {
        }

        public IEnumerable<Models.V1.Object> GetAllV1()
        {
            return sampleProductsV1;
        }

        public Models.V1.Object? GetV1(string? id, string? uri, string? selectedPropertiesStr)
        {
            var product = sampleProductsV1.FirstOrDefault(x => x.Id == id || x.Uri.ToString() == uri);
            if (product == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(selectedPropertiesStr))
            {
                product.SelectedProperties = selectedPropertiesStr.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            }

            return product;
        }


        public IEnumerable<Models.V1.Object> GetAllV2()
        {
            return sampleProductsV2;
        }

        public Models.V1.Object? GetV2(string? id, string? uri, string? selectedPropertiesStr)
        {
            var product = sampleProductsV2.FirstOrDefault(x => x.Id == id || x.Uri.ToString() == uri);
            if (product == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(selectedPropertiesStr))
            {
                product.SelectedProperties = selectedPropertiesStr.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            }

            return product;
        }


        public IEnumerable<Models.V1.Object> GetAllV3()
        {
            return sampleProductsV3;
        }

        public object? GetV3(string? id, string? uri, string? selectedPropertiesStr)
        {
            var product = sampleProductsV3.FirstOrDefault(x => x.Id == id || x.Uri.ToString() == uri);
            if (product == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(selectedPropertiesStr))
            {
                product.SelectedProperties = selectedPropertiesStr.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            }

            var property = product.Properties.FirstOrDefault(p => p.Uri == new Uri("https://w3id.org/bot#hasSubElement"));
            if (property is not null)
            {
                List<Models.V1.Object> list = [product];

                //TODO: retrieve subelements
                if (property.Value is List<string> subElements)
                {
                    foreach (var subElement in subElements)
                    {
                        list.Add(sampleProductsV3.First(x => x.Uri.ToString() == subElement));
                    }
                }

                return list;
            }


            return product;
        }
    }
}
