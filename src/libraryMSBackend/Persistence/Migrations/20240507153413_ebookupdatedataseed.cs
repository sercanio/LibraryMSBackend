﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ebookupdatedataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c391afd6-fc2b-40a9-a945-b90b817c2ae7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29cd3287-0ecf-4754-b108-81949eb62a42"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 581, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 582, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 18, 34, 12, 583, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 584, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 7, 18, 34, 12, 584, DateTimeKind.Local).AddTicks(8635), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 7, 18, 34, 12, 584, DateTimeKind.Local).AddTicks(8626), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 7, 18, 34, 12, 584, DateTimeKind.Local).AddTicks(8633), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 7, 18, 34, 12, 584, DateTimeKind.Local).AddTicks(8640), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 7, 18, 34, 12, 584, DateTimeKind.Local).AddTicks(8638), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 586, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 34, 12, 587, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 15, 34, 12, 589, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("0170e1d0-20ac-4124-8de5-bf31080fa7cb"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 137, 232, 162, 230, 205, 59, 130, 203, 209, 69, 247, 75, 130, 53, 29, 220, 14, 23, 228, 52, 132, 68, 142, 64, 215, 148, 40, 203, 216, 234, 45, 115, 183, 179, 211, 199, 77, 148, 173, 86, 100, 229, 40, 78, 2, 140, 191, 113, 244, 154, 15, 108, 59, 42, 215, 1, 141, 118, 111, 105, 167, 153, 184, 86 }, new byte[] { 80, 150, 242, 210, 69, 118, 195, 48, 169, 89, 143, 145, 81, 243, 21, 61, 89, 241, 16, 235, 141, 37, 68, 244, 144, 51, 31, 214, 41, 83, 22, 194, 50, 222, 12, 94, 93, 120, 136, 167, 190, 33, 134, 228, 246, 109, 135, 230, 163, 213, 71, 250, 127, 113, 42, 82, 236, 171, 18, 160, 217, 164, 213, 99, 171, 6, 251, 78, 214, 184, 185, 54, 210, 77, 159, 163, 17, 204, 6, 47, 44, 126, 93, 56, 95, 188, 33, 181, 236, 102, 128, 193, 101, 201, 40, 103, 78, 157, 39, 202, 65, 199, 163, 202, 49, 238, 48, 183, 148, 247, 30, 35, 96, 41, 62, 92, 217, 83, 247, 244, 78, 69, 241, 170, 9, 11, 123, 48 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("239b128e-ddb9-4ea1-a0f2-99d425a7f293"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("0170e1d0-20ac-4124-8de5-bf31080fa7cb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("239b128e-ddb9-4ea1-a0f2-99d425a7f293"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0170e1d0-20ac-4124-8de5-bf31080fa7cb"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 535, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 536, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 18, 21, 44, 537, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 538, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 21, 44, 538, DateTimeKind.Local).AddTicks(8176), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 21, 44, 538, DateTimeKind.Local).AddTicks(8166), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 21, 44, 538, DateTimeKind.Local).AddTicks(8173), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 21, 44, 538, DateTimeKind.Local).AddTicks(8181), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 21, 44, 538, DateTimeKind.Local).AddTicks(8179), "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 540, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 11, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 15, 21, 44, 541, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 15, 21, 44, 543, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("29cd3287-0ecf-4754-b108-81949eb62a42"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 191, 131, 145, 42, 57, 2, 236, 219, 216, 58, 121, 223, 80, 4, 170, 96, 146, 155, 197, 33, 163, 180, 229, 154, 152, 173, 141, 19, 226, 42, 237, 73, 132, 195, 52, 99, 124, 109, 242, 10, 47, 219, 117, 174, 164, 231, 59, 61, 242, 168, 84, 165, 40, 124, 115, 116, 42, 226, 93, 40, 125, 1, 99, 15 }, new byte[] { 39, 65, 199, 54, 68, 34, 2, 108, 85, 232, 68, 95, 6, 195, 248, 230, 83, 203, 208, 111, 89, 2, 94, 223, 81, 115, 251, 236, 100, 198, 151, 255, 92, 27, 16, 60, 20, 16, 215, 93, 235, 208, 139, 10, 136, 65, 164, 18, 204, 95, 97, 121, 26, 33, 143, 4, 108, 75, 7, 251, 56, 51, 211, 243, 75, 124, 185, 29, 163, 151, 252, 187, 168, 81, 130, 206, 48, 152, 200, 31, 24, 62, 179, 184, 162, 4, 241, 85, 74, 30, 132, 185, 34, 235, 156, 114, 1, 192, 26, 205, 244, 162, 36, 213, 214, 13, 63, 213, 112, 18, 36, 228, 42, 204, 183, 51, 252, 89, 224, 175, 84, 42, 128, 83, 234, 233, 182, 245 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c391afd6-fc2b-40a9-a945-b90b817c2ae7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("29cd3287-0ecf-4754-b108-81949eb62a42") });
        }
    }
}