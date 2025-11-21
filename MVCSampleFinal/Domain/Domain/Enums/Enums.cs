using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum EquipmentType
    {
        Tractor,
        Plow,
        Harvester,
        Seeder,
        Sprayer
    }

    public enum EquipmentStatus
    {
        Available,
        InUse,
        UnderMaintenance,
        Decommissioned
    }
    public enum SalaEstado
    {
        Disponible,
        Ocupada,
        Mantenimiento
    }

    public enum EquipoEstado
    {
        Disponible,
        Asignado,
        Dañado,
        Mantenimiento
    }

    public enum SolicitudEstado
    {
        Pendiente,
        Aprobada,
        Rechazada
    }

    public enum ReporteTipo
    {
        Sala,
        Equipo
    }

    public enum ReporteEstado
    {
        Pendiente,
        EnProceso,
        Resuelto
    }
}
