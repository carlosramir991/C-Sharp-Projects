# Generated by Django 2.2.5 on 2020-10-13 00:50

from django.db import migrations, models
import django.utils.timezone


class Migration(migrations.Migration):

    dependencies = [
        ('PokeDex', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='sighting',
            name='Pokemon_Date',
            field=models.DateField(default=django.utils.timezone.now, max_length=20),
            preserve_default=False,
        ),
    ]
