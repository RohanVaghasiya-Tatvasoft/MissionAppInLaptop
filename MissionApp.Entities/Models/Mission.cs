﻿using System;
using System.Collections.Generic;

namespace MissionApp.Entities.Models;

public partial class Mission
{
    public int MissionId { get; set; }

    public int MissionThemeId { get; set; }

    public int CityId { get; set; }

    public int CountryId { get; set; }

    public string? Title { get; set; }

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public string MissionImage { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? MissionType { get; set; }

    public int? Seats { get; set; }

    public DateTime? Deadline { get; set; }

    public int? MissionStatus { get; set; }

    public string? OrganizationName { get; set; }

    public string? OrganizationDetail { get; set; }

    public string? MissionAvailability { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<FavouriteMission> FavouriteMissions { get; } = new List<FavouriteMission>();

    public virtual ICollection<GoalMission> GoalMissions { get; } = new List<GoalMission>();

    public virtual ICollection<MissionApplication> MissionApplications { get; } = new List<MissionApplication>();

    public virtual ICollection<MissionDocument> MissionDocuments { get; } = new List<MissionDocument>();

    public virtual ICollection<MissionInvite> MissionInvites { get; } = new List<MissionInvite>();

    public virtual ICollection<MissionMedium> MissionMedia { get; } = new List<MissionMedium>();

    public virtual ICollection<MissionRating> MissionRatings { get; } = new List<MissionRating>();

    public virtual ICollection<MissionSkill> MissionSkills { get; } = new List<MissionSkill>();

    public virtual MissionTheme MissionTheme { get; set; } = null!;

    public virtual ICollection<Story> Stories { get; } = new List<Story>();

    public virtual ICollection<Timesheet> Timesheets { get; } = new List<Timesheet>();
}
